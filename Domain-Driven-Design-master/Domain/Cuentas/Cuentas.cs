using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Domain.Cuentas
{
    public class Cuentas
    {
        public int cedula;
        public decimal cuenta;

        public Cuentas(int cedulas, decimal cuentas)
        {
            cedula = cedulas;
            cuenta = cuentas;
        }

        //public void AddCuenta(int cedula, decimal cuenta)
        //{
        //    #region conexión
        //    SqlConnection sql = new SqlConnection();
        //    sql.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarm\source\repos\DomainDrivenDesign\Infraestructure\BusinessDB.mdf;Integrated Security=True";
        //    sql.Open();
        //    Console.WriteLine($"{sql.State}");
        //    #endregion

        //    SqlCommand command = new SqlCommand("ppInsertCuenta", sql);
        //    command.Parameters.AddWithValue("@cedula", cedula);
        //    command.Parameters.AddWithValue("@Cuentas", cuenta);

        //    //Ejecución de comando
        //    command.CommandType = System.Data.CommandType.StoredProcedure;
        //    int Resultado = command.ExecuteNonQuery();
        //    Console.WriteLine($"Registros ingresados: {Resultado}");
        //    command.Parameters.Clear();
        //}
    }
}
