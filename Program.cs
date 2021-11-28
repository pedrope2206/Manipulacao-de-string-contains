using System;

namespace ContaisTarefa
{
    class Program
    {
        static void Main(string[] args)

        {
            //O contains ser para verificar se existe ou não um ou mais determinado caracteres 
            //iguais dentro de um texto ou cadeia de caracteres

            // sintaxe: variavel.contains('carcter');

            //Neste algoritimo foi inicializada uma variavem "curso" com uma frase
            //Depois numa estrutura if else o contains foi usado para verificar se exitia ou não 
            //o caracter 'e' caso ele existisse deveria usar o metodo replace para subtitui-lo pelo &

            string curso = "Desenvolvimento de sistemas";
            Console.WriteLine($"Frase antes do uso do contains: {curso}");

            if (curso.Contains('e'))
            {
                curso = curso.Replace('e', '&');
                Console.WriteLine($"Frase depois do uso do contains: {curso}");
            }





        }
    }
}
