﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DomainDrivenDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Agregar clientes
            //Cliente 1
            Domain.Client.Cliente cliente1 = new Domain.Client.Cliente("Carlos Sebastian", "Sánchez Martínez", 1234);
            cliente1.AddCliente(cliente1.nombres, cliente1.apellidos, cliente1.cedula);

            //Cliente 2
            Domain.Client.Cliente cliente2 = new Domain.Client.Cliente("Miguel", "Muñoz Benito", 9876);
            cliente2.AddCliente(cliente2.nombres, cliente2.apellidos, cliente2.cedula);
            #endregion

            Console.WriteLine("Inserte para actualizar cliente:");
            cliente2.UpdateCliente(cliente2.nombres, "Bilbao", cliente2.cedula);

            Console.WriteLine("\nListado de clientes:");
            cliente2.GetListaClientes();

            #region Agregar cuentas
            decimal n = 12314124;
            Domain.Cuentas.Cuentas cuenta1 = new Domain.Cuentas.Cuentas(1234, n);
            cuenta1.AddCuenta(cuenta1.cedula, cuenta1.cuenta);
            #endregion
            Console.ReadKey();

        }
    }
}
