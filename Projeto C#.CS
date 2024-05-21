
//declaration and assignment of variables:

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {

            int idade;
            double salario, altura;
            char genero;
            string nome;

            idade = 20;
            salario = 5800.5;
            altura = 1.63;
            genero = 'F';
            nome = "Maria Silva";

            Console.WriteLine(idade);
            Console.WriteLine(salario);
            Console.WriteLine(altura);
            Console.WriteLine(genero);
            Console.WriteLine(nome);
        }
    }
}

//data input:

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double salario1, salario2;
            string nome1, nome2;
            int idade;
            char sexo;

            Console.Write("Nome da primeira pessoa: ");
            nome1 = Console.ReadLine();

            Console.Write("Salario da primeira pessoa: ");
            salario1 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Nome da segunda pessoa: ");
            nome2 = Console.ReadLine();

            Console.Write("Salario da segunda pessoa: ");
            salario2 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite uma idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite um sexo (F/M): ");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Nome 1: " + nome1);
            Console.WriteLine("Salario 1: " + salario1.ToString("F2", CI));
            Console.WriteLine("Nome 2: " + nome2);
            Console.WriteLine("Salario 2: " + salario2.ToString("F2", CI));
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Sexo: " + sexo);
        }
    }
}

//"while" structure:

using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {

            int x, soma;
            soma = 0;

            Console.Write("Digite o primeiro numero: ");

            x = int.Parse(Console.ReadLine());

            while (x != 0) {

                soma = soma + x;    
                Console.Write("Digite outro numero: ");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("SOMA = " + soma);
        }
    }
}

//"for" structure:

using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {

            int N, i, x, soma;

            Console.Write("Quantos numeros serao digitados? ");
            N = int.Parse(Console.ReadLine());
            soma = 0;

            for (i = 1; i <= N; i++) {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }

            Console.WriteLine("SOMA = " + soma);
        }
    }
} 

//"do while" structure:

using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double C, F;
            char resp;

            do {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CI);
                F = 9.0 * C / 5.0 + 32.0;

                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CI));
                Console.Write("Deseja repetir (s/n)? ");
                resp = char.Parse(Console.ReadLine());

            } while (resp == 's');
        }
    }
} 

//"vectors" structure:


using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (i = 0; i < N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine();
            Console.WriteLine("NUMEROS DIGITADOS:");

            for (i = 0; i < N; i++) {

                Console.WriteLine(vet[i].ToString("F1", CI));
            }
        }
    }
} 

//"matrices" structure

using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {

            int M, N, i, j;
            Console.Write("Quantas linhas vai ter a matriz? ");

            M = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter a matriz? ");

            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (i = 0; i < M; i++) {
                for (j = 0; j < N; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ DIGITADA:");

            for (i = 0; i < M; i++) {
                for (j = 0; j < N; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                
            Console.WriteLine();
            }
        }
    }
}