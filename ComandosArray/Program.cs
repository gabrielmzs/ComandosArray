using System.Drawing;

namespace ComandosArray {
    internal class Program {
        static int[] numeros  = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };
        static int numeroMaior = -100;
        static int numeroMenor = 100;
        static double somador = 0;
        
        static void Menu() {

            Console.WriteLine("1 - Encontrar o Maior Valor da sequência........");
            Console.WriteLine("2 - Encontrar o Menor Valor da sequência........");
            Console.WriteLine("3 - Encontrar o Valor Médio da sequência........");
            Console.WriteLine("4 - Encontrar os 3 maiores valores da sequência.");
            Console.WriteLine("5 - Encontrar os valores negativos da sequência.");
            Console.WriteLine("6 - Mostrar na Tela os valores da sequência.....");
            Console.WriteLine("7 - Remover um item da sequência................");

            Console.Write("Escolha o que fazer: ");
        }
        static void FuncaoMaiorValor() {
            for (int i = 0; i < numeros.Length; i++) {
                if (numeros[i] > numeroMaior) {
                    numeroMaior = numeros[i];
                }

            }
            Console.Clear();
            Console.WriteLine($"O maior valor é: {numeroMaior}");
        }
        static void FuncaoMenorValor() {
            for (int i = 0; i < numeros.Length; i++) {
                if (numeros[i] < numeroMenor) {
                    numeroMenor = numeros[i];
                }

            }
            Console.Clear();
            Console.WriteLine($"O menor valor é: {numeroMenor}");

        }
        static void FuncaoValorMedio() {
            for (int i = 0; i < numeros.Length; i++) {
                somador += numeros[i];
            }
            Console.Clear();
            Console.WriteLine($"A média dos valores é: {somador / numeros.Length}");
        }
        static void Funcao3MaioresValores() {
            
            Console.Clear();
            Array.Sort(numeros);
            Console.WriteLine($"Os três maiores valores: {numeros[13]}, {numeros[14]}, {numeros[15]}");

            //for (int i = numeros.Length; i < numeros.Length-2; i--) {
            //    Console.Write($"{numeros[i]}, ");
            //}
        }
        static void FuncaoValoresNegativos() {
            Console.Clear();
            Array.Sort(numeros);
            Console.Write("Números Negativos: ");
            for (int i = 0; i < numeros.Length; i++) {
                if (numeros[i] < 0) {
                    Console.Write($"{numeros[i]}, ");
                }
            }
        }
        static void FuncaoMostrarValores() {
            Console.Clear();
            
            Console.Write("Números no Array: ");
            for (int i = 0; i < numeros.Length; i++) {
                    Console.Write($"{numeros[i]}, ");
            }
        }
        static void FuncaoExcluirValor() {

            Console.Clear();
            Console.Write("Números no Array: ");
            for (int i = 0; i < numeros.Length; i++) {
                Console.Write($"{numeros[i]}, ");
            }

            Console.WriteLine("Determine a posicão que o valor deverá ser excluido:");
            int deletar = int.Parse(Console.ReadLine());


            foreach (int numero in numeros) {
                Console.WriteLine(numero);
            }
        }
        static void Main(string[] args) {
            Menu();
            int escolha = int.Parse(Console.ReadLine());
            
            switch (escolha) {
                case 1: FuncaoMaiorValor(); break;
                case 2: FuncaoMenorValor(); break;
                case 3: FuncaoValorMedio(); break;
                case 4: Funcao3MaioresValores(); break;
                case 5: FuncaoValoresNegativos();break;
                case 6: FuncaoMostrarValores(); break;
                case 7: FuncaoExcluirValor(); break;
            }
        }
    }
}