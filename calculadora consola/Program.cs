// importa librerias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main()
        {
            // Define las variables
            char operador;
            double n1 = 0, n2 = 0, res;
            int error = 0;

            //Bucle
            while (true)
            {
                error = 0; // restablece el valor de error

                // ingresa los datos
                Console.Write("ingrese el primer numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("ingrese la operacion(+,-,*,/) : ");
                operador = Convert.ToChar(Console.ReadLine());

                switch (operador) //Verifica que la operacion sea valida
                {
                    case '+':
                        operador = '+';
                        break;

                    case '-':
                        operador = '-';
                        break;

                    case '*':
                        operador = '*';
                        break;
                    case '/':
                        operador = '/';
                        break;
                    default:
                        Console.WriteLine("operacion no valida");
                        error = 1;
                        break;
                }
                if (error == 0) // si la operacion es valida continua
                {
                    Console.Write("ingrese el segundo numero: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    
                    switch (operador) // realiza las repectivas operaciones
                    {
                        case '+':
                            res = n1 + n2;
                            Console.WriteLine(n1+" + "+n2+" = "+res);
                            break;

                        case '-':
                            res = n1 - n2;
                            Console.WriteLine(n1+" - "+n2+" = "+res);
                            break;

                        case '*':
                            res = n1 * n2;
                            Console.WriteLine(n1+" * "+n2+" = "+res);
                            break;

                        case '/':
                            if (n2 != 0) // verifica que la operacion sea posible
                            {
                                res = n1 / n2;
                                Console.WriteLine(n1+" / "+n2+" = "+res);
                            }
                            else
                            {
                                Console.WriteLine("Operacion Invalida");
                            }
                            break;
                    }
                
                }
                Console.ReadLine(); 
            }
        }
    }
}
