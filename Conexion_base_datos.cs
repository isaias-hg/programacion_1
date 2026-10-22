
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Microsoft.Data.SqlClient;

namespace ParcialII
{
    public class Conexion_base_datos
    {
        private const string SERVIDOR = @"(LocalDB)\MSSQLLocalDB";
        private const string BASE_DATOS = "BD_PARCIAL_II";

        // Carpeta donde se guardan los archivos de la base de datos
        private const string CARPETA_BD =
            @"C:\Users\LENOVO\Downloads\Parcial_II\ParcialII\base de datos";

        private static readonly string ARCHIVO_MDF = Path.Combine(CARPETA_BD, "base de datos.mdf");
        private static readonly string ARCHIVO_LDF = Path.Combine(CARPETA_BD, "base de datos_log.ldf");

        private const string CADENA_MASTER =
            "Data Source=" + SERVIDOR + ";Initial Catalog=master;" +
            "Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=False;TrustServerCertificate=True;";

        private const string CADENA_CONEXION =
            "Data Source=" + SERVIDOR + ";Initial Catalog=" + BASE_DATOS + ";" +
            "Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=False;TrustServerCertificate=True;";

        private const string TABLA_SQL = "[dbo].[usuarios_usss008426]";
        private const string TABLA_DATASET = "usuarios_usss008426";

        private static string errorInicio = "";

        private DataSet ds = new DataSet();

        // Crea la carpeta, la base de datos (en esa carpeta), la tabla y los usuarios de ejemplo
        static Conexion_base_datos()
        {
            try
            {
                Directory.CreateDirectory(CARPETA_BD);

                string mdf = ARCHIVO_MDF.Replace("'", "''");
                string ldf = ARCHIVO_LDF.Replace("'", "''");
                string sqlCrear;

                if (File.Exists(ARCHIVO_MDF))
                {
                    // Ya existe el archivo: se adjunta a LocalDB
                    sqlCrear =
                        "IF DB_ID(N'" + BASE_DATOS + "') IS NULL " +
                        "CREATE DATABASE [" + BASE_DATOS + "] " +
                        "ON (FILENAME = N'" + mdf + "') FOR ATTACH;";
                }
                else
                {
                    // No existe: se crea dentro de la carpeta indicada
                    sqlCrear =
                        "IF DB_ID(N'" + BASE_DATOS + "') IS NULL " +
                        "CREATE DATABASE [" + BASE_DATOS + "] " +
                        "ON PRIMARY (NAME = N'" + BASE_DATOS + "', FILENAME = N'" + mdf + "') " +
                        "LOG ON (NAME = N'" + BASE_DATOS + "_log', FILENAME = N'" + ldf + "');";
                }

                using (SqlConnection cn = new SqlConnection(CADENA_MASTER))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlCrear, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                using (SqlConnection cn = new SqlConnection(CADENA_CONEXION))
                {
                    cn.Open();

                    string crearTabla =
                        "IF OBJECT_ID('dbo.usuarios_usss008426', 'U') IS NULL " +
                        "CREATE TABLE dbo.usuarios_usss008426 (" +
                        "idUsuario INT IDENTITY(1,1) NOT NULL PRIMARY KEY, " +
                        "usuario VARCHAR(35) NOT NULL, " +
                        "clave VARCHAR(35) NOT NULL, " +
                        "nombre VARCHAR(65) NOT NULL, " +
                        "direccion VARCHAR(85) NULL, " +
                        "telefono VARCHAR(9) NULL);";

                    using (SqlCommand cmd = new SqlCommand(crearTabla, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    string datosEjemplo =
                        "IF NOT EXISTS (SELECT 1 FROM dbo.usuarios_usss008426) " +
                        "INSERT INTO dbo.usuarios_usss008426 (usuario, clave, nombre, direccion, telefono) VALUES " +
                        "('administrador', 'admin2026', 'Administrador del Sistema', 'Usulutan, El Salvador', '2662-0001'), " +
                        "('jperez2026', 'clave1234', 'Juan Perez', 'San Miguel', '7000-1111'), " +
                        "('mlopez2026', 'clave5678', 'Maria Lopez', 'Santiago de Maria', '7000-2222');";

                    using (SqlCommand cmd = new SqlCommand(datosEjemplo, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorInicio = ex.Message;
            }
        }

        // Si falló la creación de la base de datos, muestra el error real
        private static void verificarInicio()
        {
            if (errorInicio != "")
                throw new Exception("No se pudo preparar la base de datos en:\n" +
                                    CARPETA_BD + "\n\n" + errorInicio);
        }

        public DataSet crearDs()
        {
            verificarInicio();
            ds = new DataSet();

            using (SqlConnection cn = new SqlConnection(CADENA_CONEXION))
            {
                string sql =
                    "SELECT idUsuario, usuario, clave, nombre, " +
                    "direccion, telefono " +
                    "FROM " + TABLA_SQL +
                    " ORDER BY idUsuario";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                {
                    da.Fill(ds, TABLA_DATASET);
                }
            }

            return ds;
        }

        public string procesar(string sql, params SqlParameter[] parametros)
        {
            try
            {
                verificarInicio();

                using (SqlConnection cn = new SqlConnection(CADENA_CONEXION))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    if (parametros != null && parametros.Length > 0)
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

        public string mantenimiento_usuarios_usss008426(string[] datos, string accion)
        {
            if (datos == null)
                return "No se recibieron los datos.";

            string sql;
            List<SqlParameter> parametros = new List<SqlParameter>();

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

                        parametros.Add(new SqlParameter("@idUsuario", SqlDbType.Int)
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

                        parametros.Add(new SqlParameter("@idUsuario", SqlDbType.Int)
                        {
                            Value = idEliminar
                        });

                        return procesar(sql, parametros.ToArray());

                    default:
                        return "Acción no válida.";
                }

                if (datos.Length < 6)
                    return "Faltan datos del usuario.";

                parametros.Add(new SqlParameter("@usuario", SqlDbType.VarChar, 35)
                {
                    Value = datos[1] ?? ""
                });

                parametros.Add(new SqlParameter("@clave", SqlDbType.VarChar, 35)
                {
                    Value = datos[2] ?? ""
                });

                parametros.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 65)
                {
                    Value = datos[3] ?? ""
                });

                parametros.Add(new SqlParameter("@direccion", SqlDbType.VarChar, 85)
                {
                    Value = datos[4] ?? ""
                });

                parametros.Add(new SqlParameter("@telefono", SqlDbType.VarChar, 9)
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

        public bool validarLogin(string usuario, string clave, out string nombre)
        {
            nombre = "";
            verificarInicio();

            string sql =
                "SELECT nombre FROM " + TABLA_SQL +
                " WHERE usuario = @usuario " +
                "AND clave COLLATE Latin1_General_CS_AS = @clave";

            using (SqlConnection cn = new SqlConnection(CADENA_CONEXION))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar, 35)
                {
                    Value = usuario
                });

                cmd.Parameters.Add(new SqlParameter("@clave", SqlDbType.VarChar, 35)
                {
                    Value = clave
                });

                cn.Open();

                object resultado = cmd.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                {
                    return false;
                }

                nombre = Convert.ToString(resultado) ?? "";
                return true;
            }
        }
    }
}