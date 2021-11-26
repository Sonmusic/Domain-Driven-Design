using Domain.Client;
using DomainDrivenDesign.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Service.Impl
{
    public class CuentaService : ICuentaService
    {
        public static void AddCliente(Cliente cliente)
        {
            #region conexión
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarm\source\repos\DomainDrivenDesign\Infraestructure\BusinessDB.mdf;Integrated Security=True";
            sql.Open();
            Console.WriteLine($"{sql.State}");
            #endregion

            //Agregar cliente 1
            SqlCommand command = new SqlCommand("ppInsertCliente", sql);
            command.Parameters.AddWithValue("@nombres", cliente.nombres);
            command.Parameters.AddWithValue("@apellidos", cliente.apellidos);
            command.Parameters.AddWithValue("@cedula", cliente.cedula);

            //Ejecución de comando
            command.CommandType = System.Data.CommandType.StoredProcedure;
            int Resultado = command.ExecuteNonQuery();
            Console.WriteLine($"Registros ingresados: {Resultado}");
            command.Parameters.Clear();

        }

        public static void UpdateCliente(Cliente cliente)
        {
            #region conexión
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarm\source\repos\DomainDrivenDesign\Infraestructure\BusinessDB.mdf;Integrated Security=True";
            sql.Open();
            Console.WriteLine($"{sql.State}");
            #endregion

            //Agregar cliente 1
            SqlCommand command = new SqlCommand("ppInsertCliente", sql);
            command.Parameters.AddWithValue("@nombres", cliente.nombres);
            command.Parameters.AddWithValue("@apellidos", cliente.apellidos);
            command.Parameters.AddWithValue("@cedula", cliente.cedula);

            //Ejecución de comando
            command.CommandType = System.Data.CommandType.StoredProcedure;
            int Resultado = command.ExecuteNonQuery();
            Console.WriteLine($"Registros ingresados: {Resultado}");
            command.Parameters.Clear();
        }

        public static void GetListaClientes()
        {
            #region conexión
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarm\source\repos\DomainDrivenDesign\Infraestructure\BusinessDB.mdf;Integrated Security=True";
            sql.Open();
            Console.WriteLine($"{sql.State}");
            #endregion


            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand("ppGetCliente", sql);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"Cedula: {dr["Id"]}- Nombre: {dr["nombres"]}- Apellido: {dr["apellidos"]}- Fecha de actualización: {dr["FechaIngreso"]}");
            }
            dr.Close();
        }
    }
}
