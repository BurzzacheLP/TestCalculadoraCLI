using System;
using System.Text;

namespace MyNamespace
{
    class program
    {
        static public void Main(string[] args)
        {
            /* LA IDEA
             * La idea es q el programa separe el calculo en terminos,
             * tomando en cuenta el orden de los calculos 
             * Parentesis , Raiz > Exponentes > Multiplicaciones, Divisiones > Sumas, Restas
             * Deberia resolverlas en ese orden, tomando en cuenta donde empieza un termino y empieza el otro
             * luego ordenarlos, calcularlos, e ir resolviendo 
             * 
            */

            //SplitTerminos();

            SubTerminos();

        }

        static string SplitTerminos()
        {
            string StringCalculo = Console.ReadLine();


            string[] subs = StringCalculo.Split( '+', '-', '*', '/', '^', 'V');
            
            //Definir el array subs para separar en terminos

            foreach (var sub in subs)                
            {
                Console.WriteLine($"Terminos: {sub}");
                switch(sub)
                {
                    case "+":
                        Console.WriteLine("Suma");
                        break;
                }
            }
            
            


            // Convertir los valores dedl array en double, por si coma, pero como no puse comas en la calculadora ni modo pe jjjjj
            /*double[] doubles = Array.ConvertAll(stringCalculo.Split(','), new Converter<string, double>(Double.Parse));
            


            
            foreach (var duble in doubles)
            {
                Console.WriteLine($"dOBLE {duble}");
            }
            
            */
            string resultado = subs[0];


            return resultado;
        }


        static string SubTerminos()
        {
            string StringCalculo = Console.ReadLine();
            char[] expresiones = StringCalculo.ToCharArray();

            double[] numeros = new double[expresiones.Length];

            int found = 0;

            /* NOTA DE ESQUIZOFRENIA:
             * PENSE EN HACER UN ARRAY CON TODOS LOS NUMEROS DELE 0 AL 9 Y QUE CUANDO NO ENCUENTRE UN NUMERO SUBDIVIDA EL STRING
             * SUENA A DOWN
             * 
             * O PODRIA HACER Q SI SE ENCUENTRA UN SIGNO != AL DEL CASE Q NO SE SE TERMINE AHI EL TERMINO
             * 
             * Y SI HCIERA UN CONTADOR Q CUENTE CADA NUMERO Y CUANDO ENUENTRE OTRO VALOR CORTE LA CUENTA?   
             * 
             * 
             * 
             * y si guardara el ultimo operador q leyo y con un if si es distinto se corte?
             */

            foreach (char ch in expresiones)
            {
                /*
                switch (ch)
                {
                    case '+':
                        found = StringCalculo.IndexOf("+");
                        //Console.WriteLine("Termino: {0}", StringCalculo.Substring(found + 0));
                        
                        Console.WriteLine("Termino: {0}", StringCalculo.Split('+', found + 2));

                        break;

                    case '-':
                        found = StringCalculo.IndexOf("-");
                        Console.WriteLine("Termino: {0}", StringCalculo.Substring(found + 0));

                        break;

                    case '*':
                        // Multipliacion
                        found = StringCalculo.IndexOf("*");
                        Console.WriteLine("Termino: {0}", StringCalculo.Substring(found + 0));
                        break;

                    case '/':
                        //Division
                        found = StringCalculo.IndexOf("/");
                        Console.WriteLine("Termino: {0}", StringCalculo.Substring(found + 0));
                        break;

                    case '^':
                        // Potencia
                        found = StringCalculo.IndexOf("^");
                        Console.WriteLine("Termino: {0}", StringCalculo.Substring(found + 0));
                        break;

                    case 'V':
                        // Raiz
                        found = StringCalculo.IndexOf("V");
                        Console.WriteLine("Termino: {0}", StringCalculo.Substring(found + 0));
                        break;

                    default:
                        continue;
                }
                */
                foreach (int num in numeros)
                {
                    ch.GetType();
                    
                }
                
            }



            string resultado = "";
            return resultado;
        }
    }

}