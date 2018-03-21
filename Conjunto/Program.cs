using System;
using System.Collections.Generic; // Classe oferece os recuros para trabalhar com conjuntos
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>(); //Curso A
            HashSet<int> B = new HashSet<int>(); //Curso B
            HashSet<int> C = new HashSet<int>(); //Curso C

            A.Add(1); //Aluno código 1
            A.Add(3); //Aluno código 3
            A.Add(5);

            B.Add(2);
            B.Add(3);
            B.Add(4);

            C.Add(5);
            C.Add(8);
            C.Add(9);

            MostraConjunto(A);
            MostraConjunto(B);
            MostraConjunto(C);

            //QUantos alunos únicos temos nos três cursos??
            A.UnionWith(B); // Conjuntos não duplicam elementos, então os alunos em mais de um curso não serão levados
            A.UnionWith(C);

            //Mostra somente os alunos que estão no curso A estão no Curso B
            Console.Write("Total de alunos do Professor: ");
            Console.Write(A.Count);
            Console.WriteLine();

            MostraConjunto(A);

            /*
            Console.WriteLine("Digite um valor inteiro:");
            int Valor = int.Parse(Console.ReadLine());

            if (A.Contains(Valor))
            {
                Console.WriteLine("Valor está contido em A");
            }
            else
            {
                Console.WriteLine("Valor não está contido em A");
            }

            Console.ReadLine();
            */

            // Remover de A tudo que pertence ao B
            //A.ExceptWith(B);
            //MostraConjunto(A);

            // JOIN entre A e B
            //A.IntersectWith(B);
            //MostraConjunto(A)

            // UNION entre A e B
            //A.UnionWith(B);
            //MostraConjunto(A);

        }

        static void MostraConjunto( HashSet<int> nomeCojunto )
        {
            foreach( int x in nomeCojunto)
            {
                Console.WriteLine(x.ToString());
            }
            Console.ReadLine();
        }
    }
}
