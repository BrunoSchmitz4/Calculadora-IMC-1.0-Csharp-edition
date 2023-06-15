using System;
using System.Globalization;

namespace PrimeiroAplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            float testepeso = 80;
            float testealtura = 1.78f;

            Console.WriteLine(testepeso / (testealtura * testealtura));
            float imc = 0.0f;

            Console.WriteLine("Olá! Bem vindo(a) à calculadora de IMC." +
                "\nNão considere o resultado como definitivo!\nPois bem, insira seu nome abaixo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Tudo bem, {0}, quantos anos você tem?", nome);
            int idade = int.Parse(Console.ReadLine());

            if(idade < 18)
            {
                Console.WriteLine("Desculpe, só é permitido o cálculo do IMC para maiores que 18 anos");
            }
            else
            {
                Console.WriteLine("Tudo bem " + nome + ", como você tem " + idade + " anos," +
                    "\njá podemos fazer o cálculo. Qual o seu gênero? Homem(H)/Mulher(M)");
                string gender = Console.ReadLine();

                Console.WriteLine("Certo, insira sua altura: ");
                float altura = float.Parse(Console.ReadLine());

                Console.WriteLine("Quase acabando...e qual seria o seu peso?");
                float peso = float.Parse(Console.ReadLine());

                imc = peso / (altura * altura);

                if (gender == "h" && imc > 25)
                {
                    Console.WriteLine("Você está acima do peso.");
                    Console.WriteLine("IMC: " + imc);
                    Console.WriteLine("Gênero: " + gender);
                    Console.WriteLine("Peso: " + peso);
                    Console.WriteLine("Altura: " + altura);
                }
                else if (gender == "H" && imc > 25)
                {
                    Console.WriteLine("Você está acima do peso.");
                    Console.WriteLine("IMC: " + imc);
                    Console.WriteLine("Gênero: " + gender);
                    Console.WriteLine("Peso: " + peso);
                    Console.WriteLine("Altura: " + altura);
                }
                else if (gender == "m" && imc > 30)
                {
                    Console.WriteLine("Você está acima do peso.");
                    Console.WriteLine("IMC: " + imc);
                    Console.WriteLine("Gênero: " + gender);
                    Console.WriteLine("Peso: " + peso);
                    Console.WriteLine("Altura: " + altura);
                }
                else if (gender == "M" && imc > 30)
                {
                    Console.WriteLine("Você está acima do peso.");
                    Console.WriteLine("IMC: " + imc);
                    Console.WriteLine("Gênero: " + gender);
                    Console.WriteLine("Peso: " + peso);
                    Console.WriteLine("Altura: " + altura);
                }
                else
                {
                    Console.WriteLine("Ainda não temos estrutura de resposta para esta condição: ");
                    Console.WriteLine("IMC: " + imc);
                    Console.WriteLine("Gênero: " + gender);
                    Console.WriteLine("Peso: " + peso);
                    Console.WriteLine("Altura: " + altura);
                }
            }
        }
    }

}