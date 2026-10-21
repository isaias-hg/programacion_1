
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ParcialII
{
    public class Conexion_base_datos
    {
        // Archivo de la base de datos
        private const string CADENA_CONEXION =
            @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=|DataDirectory|\script_base_datos.mdf;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "TrustServerCertificate=True;";

        // Nombre de la tabla en SQL Server
        private const string TABLA_SQL =
            "[dbo].[usuarios_usss008426]";

        // Nombre de la tabla dentro del DataSet
        private const string TABLA_DATASET =
            "dbo.usuarios_usss008426";

        private DataSet ds = new DataSet();

        // ==========================================
        // CARGAR LOS DATOS DE LOS USUARIOS
        // ==========================================
        public DataSet crearDs()
        {
            ds = new DataSet();

            using (SqlConnection cn =
                new SqlConnection(CADENA_CONEXION))
            {
                string sql =
                    "SELECT idUsuario, usuario, clave, nombre, " +
                    "direccion, telefono " +
                    "FROM " + TABLA_SQL +
                    " ORDER BY idUsuario";

                using (SqlDataAdapter da =
                    new SqlDataAdapter(sql, cn))
                {
                    da.Fill(ds, TABLA_DATASET);
                }
            }

            return ds;
        }

        // ==========================================
        // EJECUTAR INSERT, UPDATE Y DELETE
        // ==========================================
        public string procesar(
            string sql,
            params SqlParameter[] parametros)
        {
            try
            {
                using (SqlConnection cn =
                    new SqlConnection(CADENA_CONEXION))
                using (SqlCommand cmd =
                    new SqlCommand(sql, cn))
                {
                    if (parametros != null &&
                        parametros.Length > 0)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // ==========================================
        // MANTENIMIENTO DE USUARIOS
        // ==========================================
        // datos[0] = idUsuario
        // datos[1] = usuario
        // datos[2] = clave
        // datos[3] = nombre
        // datos[4] = direccion
        // datos[5] = telefono

        public string mantenimiento_usuarios_usss008426(
            string[] datos,
            string accion)
        {
            if (datos == null)
                return "No se recibieron los datos.";

            string sql;
            List<SqlParameter> parametros =
                new List<SqlParameter>();

            try
            {
                switch (accion)
                {
                    case "nuevo":

                        sql = "INSERT INTO " + TABLA_SQL +
                              " (usuario, clave, nombre, direccion, telefono) " +
                              "VALUES (@usuario, @clave, @nombre, @direccion, @telefono)";
                        break;

                    case "modificar":

                        if (datos.Length < 6 ||
                            !int.TryParse(datos[0], out int idModificar))
                        {
                            return "El ID del usuario no es válido.";
                        }

                        sql = "UPDATE " + TABLA_SQL +
                              " SET usuario = @usuario, " +
                              "clave = @clave, " +
                              "nombre = @nombre, " +
                              "direccion = @direccion, " +
                              "telefono = @telefono " +
                              "WHERE idUsuario = @idUsuario";

                        parametros.Add(
                            new SqlParameter("@idUsuario",
                                SqlDbType.Int)
                            {
                                Value = idModificar
                            });

                        break;

                    case "eliminar":

                        if (datos.Length == 0 ||
                            !int.TryParse(datos[0], out int idEliminar))
                        {
                            return "El ID del usuario no es válido.";
                        }

                        sql = "DELETE FROM " + TABLA_SQL +
                              " WHERE idUsuario = @idUsuario";

                        parametros.Add(
                            new SqlParameter("@idUsuario",
                                SqlDbType.Int)
                            {
                                Value = idEliminar
                            });

                        return procesar(sql, parametros.ToArray());

                    default:
                        return "Acción no válida.";
                }

                if (datos.Length < 6)
                    return "Faltan datos del usuario.";

                parametros.Add(
                    new SqlParameter("@usuario",
                        SqlDbType.VarChar, 35)
                    {
                        Value = datos[1] ?? ""
                    });

                parametros.Add(
                    new SqlParameter("@clave",
                        SqlDbType.VarChar, 35)
                    {
                        Value = datos[2] ?? ""
                    });

                parametros.Add(
                    new SqlParameter("@nombre",
                        SqlDbType.VarChar, 65)
                    {
                        Value = datos[3] ?? ""
                    });

                parametros.Add(
                    new SqlParameter("@direccion",
                        SqlDbType.VarChar, 85)
                    {
                        Value = datos[4] ?? ""
                    });

                parametros.Add(
                    new SqlParameter("@telefono",
                        SqlDbType.VarChar, 9)
                    {
                        Value = datos[5] ?? ""
                    });

                return procesar(sql, parametros.ToArray());
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // ==========================================
        // VALIDAR INICIO DE SESIÓN
        // ==========================================
        public bool validarLogin(
            string usuario,
            string clave,
            out string nombre)
        {
            nombre = "";

            string sql =
                "SELECT nombre FROM " + TABLA_SQL +
                " WHERE usuario = @usuario " +
                "AND clave COLLATE Latin1_General_CS_AS = @clave";

            using (SqlConnection cn =
                new SqlConnection(CADENA_CONEXION))
            using (SqlCommand cmd =
                new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add(
                    new SqlParameter("@usuario",
                        SqlDbType.VarChar, 35)
                    {
                        Value = usuario
                    });

                cmd.Parameters.Add(
                    new SqlParameter("@clave",
                        SqlDbType.VarChar, 35)
                    {
                        Value = clave
                    });

                cn.Open();

                object resultado = cmd.ExecuteScalar();

                if (resultado == null ||
                    resultado == DBNull.Value)
                {
                    return false;
                }

                nombre = Convert.ToString(resultado) ?? "";
                return true;
            }
        }
    }
}

