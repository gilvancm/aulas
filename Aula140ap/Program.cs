using System;
using System.Globalization;


namespace Aula140ap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception! ");
            //stack trace é o erro que aparece na tela. é conhecido como rastreamento da chamada de excessões
            // captura essa ecessão e tratar pra melhorar
            Console.WriteLine();

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                double result = n1 / n2;

                Console.WriteLine(result);

            }
            /*  tratamento generico
             catch (Exception e)
             {
                 Console.WriteLine("Erro tal ! "+e.Message);
             }
             */
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Este número não pode ser dividido por zero -- "+e.Message);
            }
            /*
            catch (FormatException e)
            {
                Console.WriteLine("Só pode digitar neste campo número e não letras -- "+e.Message);
            }
            */
            //posso fazer assim tambe
            catch (FormatException)
            {
                Console.WriteLine("Só pode digitar neste campo número e não letras ");
            }




        }
    }
}
