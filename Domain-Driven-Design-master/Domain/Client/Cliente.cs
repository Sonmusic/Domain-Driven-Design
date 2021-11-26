using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Domain.Client
{
    public class Cliente
    {
        public string nombres;
        public string apellidos;
        public int cedula;

        public Cliente(string name, string lastname, int Cedula)
        {
            nombres = name;
            apellidos = lastname;
            cedula = Cedula;
        }
        //public void AddCliente(string nombre, string apellido, int cedula)
        //{
        //    #region conexión
        //    SqlConnection sql = new SqlConnection();
        //    sql.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarm\source\repos\DomainDrivenDesign\Infraestructure\BusinessDB.mdf;Integrated Security=True";
        //    sql.Open();
        //    Console.WriteLine($"{sql.State}");
        //    #endregion

        //    //Agregar cliente 1
        //    SqlCommand command = new SqlCommand("ppInsertCliente", sql);
        //    command.Parameters.AddWithValue("@nombres", nombre);
        //    command.Parameters.AddWithValue("@apellidos", apellido);
        //    command.Parameters.AddWithValue("@cedula", cedula);

        //    //Ejecución de comando
        //    command.CommandType = System.Data.CommandType.StoredProcedure;
        //    int Resultado = command.ExecuteNonQuery();
        //    Console.WriteLine($"Registros ingresados: {Resultado}");
        //    command.Parameters.Clear();

        //}

        //public void UpdateCliente(string nombre, string apellido, int cedula)
        //{
        //    #region conexión
        //    SqlConnection sql = new SqlConnection();
        //    sql.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarm\source\repos\DomainDrivenDesign\Infraestructure\BusinessDB.mdf;Integrated Security=True";
        //    sql.Open();
        //    Console.WriteLine($"{sql.State}");
        //    #endregion

        //    //Agregar cliente 1
        //    SqlCommand command = new SqlCommand("ppInsertCliente", sql);
        //    command.Parameters.AddWithValue("@nombres", nombre);
        //    command.Parameters.AddWithValue("@apellidos", apellido);
        //    command.Parameters.AddWithValue("@cedula", cedula);

        //    //Ejecución de comando
        //    command.CommandType = System.Data.CommandType.StoredProcedure;
        //    int Resultado = command.ExecuteNonQuery();
        //    Console.WriteLine($"Registros ingresados: {Resultado}");
        //    command.Parameters.Clear();
        //}

        //public void GetListaClientes()
        //{
        //    #region conexión
        //    SqlConnection sql = new SqlConnection();
        //    sql.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarm\source\repos\DomainDrivenDesign\Infraestructure\BusinessDB.mdf;Integrated Security=True";
        //    sql.Open();
        //    Console.WriteLine($"{sql.State}");
        //    #endregion


        //    SqlDataReader dr = null;
        //    SqlCommand command = new SqlCommand("ppGetCliente", sql);
        //    dr = command.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Console.WriteLine($"Cedula: {dr["Id"]}- Nombre: {dr["nombres"]}- Apellido: {dr["apellidos"]}- Fecha de actualización: {dr["FechaIngreso"]}");
        //    }
        //    dr.Close();
        //}
    }
}

