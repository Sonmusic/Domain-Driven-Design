using Domain.Client;
using Domain.Cuentas;
using DomainDrivenDesign.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Service.Impl
{
    public class CuentasService : ICuentasService
    {
        public static void AddCuenta(Cuentas cuenta)
        {
            #region conexión
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarm\source\repos\DomainDrivenDesign\Infraestructure\BusinessDB.mdf;Integrated Security=True";
            sql.Open();
            Console.WriteLine($"{sql.State}");
            #endregion

            SqlCommand command = new SqlCommand("ppInsertCuenta", sql);
            command.Parameters.AddWithValue("@cedula", cuenta.cedula);
            command.Parameters.AddWithValue("@Cuentas", cuenta.cuenta);

            //Ejecución de comando
            command.CommandType = System.Data.CommandType.StoredProcedure;
            int Resultado = command.ExecuteNonQuery();
            Console.WriteLine($"Registros ingresados: {Resultado}");
            command.Parameters.Clear();
        }
    }
}
