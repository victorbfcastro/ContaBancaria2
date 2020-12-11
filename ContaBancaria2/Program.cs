using System;
using System.Globalization;

namespace ContaBancaria2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            ContaBancaria2.CriarConta();

        }
        
    }
}
