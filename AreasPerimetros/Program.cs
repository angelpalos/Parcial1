using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasPerimetros_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bas,altura,area,radio,perimetro,lado;
            char forma, oper;
            bool exit = true;
            
            while (exit)
            {
                Console.WriteLine("C: Cuadrado");
                Console.WriteLine("R: Rectangulo");
                Console.WriteLine("T: Triangulo");
                Console.WriteLine("O: Circulo");
                Console.WriteLine("X: Salir");
                Console.Write("Seleccione una forma: ");
                forma = Convert.ToChar(Console.ReadLine());

                if (forma == 'C' || forma == 'c')
                {
                    Console.WriteLine("Usted seleccionó el Cuadrado");

                    Console.Write("¿Cual es la medida de los lados?");
                    lado  = Convert.ToDouble(Console.ReadLine());
                
                    Console.WriteLine("A = Area");
                    Console.WriteLine("P = Perimetro");
                    Console.Write("¿Que desea obtener? ");
                    oper = Convert.ToChar(Console.ReadLine());
                
                    if (oper == 'A' || oper == 'a')
                    {
                        area = lado*lado;
                        Console.WriteLine("El area es: "+area);

                    } else if(oper == 'P' || oper == 'p') {
                        perimetro = lado*4;
                        Console.WriteLine("El perimetro es: "+perimetro);
                    }
                    else { Console.WriteLine("Operacion no Valida"); }

                } else if (forma == 'O' || forma == 'o')
                {
                    Console.WriteLine("Usted seleccionó el Circulo");

                    Console.Write("¿Cual es la medida del radio? ");
                    radio = Convert.ToDouble(Console.ReadLine());
                
                    Console.WriteLine("A = Area");
                    Console.WriteLine("P = Perimetro");
                    Console.Write("¿Que desea obtener? ");
                    oper = Convert.ToChar(Console.ReadLine());
                
                    if (oper == 'A' || oper == 'a')
                    {
                        area = 3.14159 * radio*radio;
                        Console.WriteLine("El area es: "+area);

                    } else if(oper == 'P' || oper == 'p') {
                       perimetro = 2*3.14159*radio;
                       Console.WriteLine("El perimetro es: "+perimetro);
                    }
                    else { Console.WriteLine("Operacion no Valida"); }

                }
                else if (forma == 'R' || forma == 'r')
                {
                    Console.WriteLine("Selecciono el Rectangulo ");

                    Console.Write("¿Cual es la medida de el ancho? ");
                    bas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("¿Cual es la medida de el largo? ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("A = Area");
                    Console.WriteLine("P = Perimetro");
                    Console.Write("¿Que desea obtener? ");
                    oper = Convert.ToChar(Console.ReadLine());

                    if (oper == 'A' || oper == 'a')
                    {
                        area = bas * altura;
                        Console.WriteLine("El area es " + area);

                    }
                    else if (oper == 'P' || oper == 'p')
                    {
                        perimetro = bas + altura;
                        perimetro = perimetro * 2;
                        Console.WriteLine("El perimetro es " + perimetro);

                    }
                    else { Console.WriteLine("Operacion no Valida"); }

                }
                else if (forma == 'T' || forma == 't')
                {
                    Console.WriteLine("Selecciono el Triangulo ");

                    Console.Write("¿Cual es la medida de la base? ");
                    bas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("¿cual es la medida de la altura? ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("A = Area");
                    Console.WriteLine("P = Perimetro");
                    Console.Write("¿Que desea obtener? ");
                    oper = Convert.ToChar(Console.ReadLine());

                    if (oper == 'A' || oper == 'a')
                    {
                        area = (bas * altura) / 2;
                        Console.WriteLine("El area es " + area);

                    }
                    else if (oper == 'P' || oper == 'p')
                    {
                        perimetro = bas * 3;
                        Console.WriteLine("El perimetro es " + perimetro);

                    }
                    else { Console.WriteLine("Operacion no Valida"); }

                }
                else if (forma == 'x' || forma == 'X') { exit = false;} 
                
                else { Console.WriteLine("Operacion no valida"); }

                Console.WriteLine("--------------------------------");
            }
        }
    }
}
