using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Olá! O que deseja calcular?");
            Console.WriteLine();
            Console.WriteLine("0 - Sair do Menu;");
            Console.WriteLine("1 - Soma;");
            Console.WriteLine("2 - Subtração;");
            Console.WriteLine("3 - Divisão;");
            Console.WriteLine("4 - Multiplicação;");
            Console.WriteLine("5 - Área do Quadrado;");
            Console.WriteLine("6 - Área do Retângulo;");
            Console.WriteLine("7 - Área do Triângulo;");
            Console.WriteLine("8 - Área do Círculo;");
            Console.WriteLine("9 - Área do Cilindro.");

            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 0:
                    Console.WriteLine("Obrigado por utilizar nossos serviços!");
                    System.Environment.Exit(0);
                    break;

                case 1:
                    Soma();
                    NovoCalculo();
                    break;

                case 2:
                    Subtracao();
                    NovoCalculo();
                    break;

                case 3:
                    Divisao();
                    NovoCalculo();
                    break;

                case 4:
                    Multiplicacao();
                    NovoCalculo();
                    break;

                case 5:
                    AreaQuadrado();
                    NovoCalculo();
                    break;

                case 6:
                    AreaRetangulo();
                    NovoCalculo();
                    break;

                case 7:
                    AreaTriangulo();
                    NovoCalculo();
                    break;

                case 8:
                    AreaCirculo();
                    NovoCalculo();
                    break;

                case 9:
                    AreaCilindro();
                    NovoCalculo();
                    break;

                default:                    
                    Menu();
                    break;
            }
        }

        static void NovoCalculo()
        {
            Console.WriteLine();
            Console.WriteLine("Deseja realizar um novo cálculo? [S/N]");
            char x = char.Parse(Console.ReadLine());
            if (x == 's' || x == 'S')
            {
                Menu();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Obrigado por utilizar nossos serviços.");
                System.Environment.Exit(0);
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Soma");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultadoSoma = v1 + v2;

            Console.WriteLine();
            Console.WriteLine($"Resultado da soma é: {resultadoSoma}");
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Subtração ");

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine();
            Console.WriteLine($"Resultado da subtração é: {resultado}");
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Divisão ");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine();
            Console.WriteLine($"Resultado da divisão é: {resultado}");
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Multiplicação ");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine();
            Console.WriteLine($"Resultado da multiplicação é: {resultado}");
        }

        static void AreaRetangulo()
        {
            Console.Clear();

            Console.WriteLine("Área do Retângulo ");
            Console.Write("Base (b): ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Altura (h): ");
            float h = float.Parse(Console.ReadLine());

            float areaRetangulo = b * h;

            Console.WriteLine();
            Console.WriteLine($"A valor da área do retângulo é: {areaRetangulo} m²");
        }

        static void AreaTriangulo()
        {
            Console.Clear();

            Console.WriteLine("Área do Triângulo ");
            Console.Write("Base (b): ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Altura (h): ");
            float h = float.Parse(Console.ReadLine());

            float areaTriangulo = (b * h) / 2;

            Console.WriteLine();
            Console.WriteLine($"A valor da área do Triângulo é: {areaTriangulo} m²");
        }

        static void AreaCirculo()
        {
            Console.Clear();

            Console.WriteLine("Área do Círculo ");
            Console.Write("Raio: ");
            float raio = float.Parse(Console.ReadLine());

            float areaCirculo = (float)(Math.PI * raio * raio);

            Console.WriteLine();
            Console.WriteLine($"A valor da área do Círculo é: {areaCirculo} m²");
        }

        static void AreaQuadrado()
        {
            Console.Clear();

            Console.WriteLine("Área do Quadrado");
            Console.Write("Lado: ");
            float lado = float.Parse(Console.ReadLine());

            float areaQuadrado = lado * lado;

            Console.WriteLine();
            Console.WriteLine($"A valor da área do quadrado é: {areaQuadrado} m²");
        }

        static void AreaCilindro()
        {
            Console.Clear();

            Console.WriteLine("Área do Cilindro");
            Console.Write("Raio (r): ");
            float raio = float.Parse(Console.ReadLine());

            Console.Write("Altura (h): ");
            float altura = float.Parse(Console.ReadLine());

            float areaCilindro = (float)(2 * Math.PI * raio * (raio + altura));

            Console.WriteLine();
            Console.WriteLine($"A valor da área do cilindro é: {areaCilindro} m²");

        }

    }
}
