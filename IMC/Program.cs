using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu Nome:");
            string nome = (Console.ReadLine());

            Console.WriteLine("Digite a sua Idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o seu Peso: ");
            float peso = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a sua Altura: ");
            float altura = (float) Convert.ToDouble(Console.ReadLine());
          
            

            float result = peso / (altura * altura);

            if (result < 18.5)
            {
                Console.WriteLine("Você está Abaixo do Peso");
            }
            else if (result >= 18.5 && result <= 24.9)
            {
                Console.WriteLine("Você está com peso Normal");            
            }
            else if (result >= 25 && result <= 29.9)
            {
                Console.WriteLine("Você está com Sobrepeso");
            }
            else if (result >= 30 && result <= 34.9)
            {
                Console.WriteLine("Você está com Obesidade grau I");
            }
            else if (result >= 35 && result <= 39.9)
            {
                Console.WriteLine("Você está com Obesidade grau II");
            }
            else
            {
                Console.WriteLine("Você está com Obesidade grau III");
            }

            Console.WriteLine("Nome: " + nome + "\r\nSua idade é: " + idade + "\r\nSeu peso é: " + peso + "\r\nSua Altura é: " + altura);
        }
    }
}
