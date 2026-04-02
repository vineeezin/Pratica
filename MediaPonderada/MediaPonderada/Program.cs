using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPonderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media_ponderada;

            string[] notas = Console.ReadLine().Split(' ');

            n1 = float.Parse(notas[0]);
            n2 = float.Parse(notas[1]);
            n3 = float.Parse(notas[2]);
            n4 = float.Parse(notas[3]);

            media_ponderada = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / (2 + 3 + 4 + 1);

            if (media_ponderada >= 7.0)
            {
                Console.WriteLine("Media: " + media_ponderada.ToString("F1"));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media_ponderada < 5.0)
            {
                Console.WriteLine("Media: " + media_ponderada.ToString("F1"));
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Media: " + media_ponderada.ToString("F1"));
                Console.WriteLine("Aluno em exame.");

                float exame = float.Parse(Console.ReadLine());

                Console.WriteLine("Nota do exame: " + exame);

                float nova_media = (exame + media_ponderada) / 2;

                if (nova_media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + nova_media.ToString("F1"));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + nova_media.ToString("F1"));
                }
            }
        }
    }
}
