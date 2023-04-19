using System;

namespace CajeroAutomatico
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string BuildTitle(string title)
            {
                return @$"
______________________________________________________________________

                    {title}
______________________________________________________________________

                ";
            }

            int saldo = ProgramConsts.InitialAmount;
            int operationSelected;
            do
            {
                Console.WriteLine(ProgramConsts.Menu);
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        {
                            Console.WriteLine(BuildTitle("INGRESE EL MONTO QUE DESEA DEPOSITAR"));
                            saldo = saldo + Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("TU MONTO DE DINERO SE HA GUARDADO CORRECTAMENTE");
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine(BuildTitle("CONSULTA DE SALDO"));
                            Console.WriteLine("        TU SALDO ACTUAL ES {0} ", saldo);
                            Console.WriteLine("");
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine(BuildTitle("INGRESE EL MONTO QUE DESEE RETIRAR"));
                            int retiro = Convert.ToInt32(Console.ReadLine());
                            saldo = saldo - retiro;
                            Console.WriteLine("");
                            Console.WriteLine("     TU RETIRO DE {0} SE REALIZO CORRECTAMENTE ", retiro);
                            Console.WriteLine("");
                        }
                        break;

                    case 4:
                        {
                            //Mensaje de agradecimiento al final
                            Console.WriteLine("");
                            Console.WriteLine("           GRACIAS POR USAR EL SISTEMA DE CAJERO");
                            Console.WriteLine("             AUTOMATICO MANICH, VUELVA PRONTO");
                        }
                        break;
                }
                Console.ReadKey();
                operationSelected = operation;
            } while (operationSelected != 4);
        }
    }
}