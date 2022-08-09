using System;
using System.Globalization;

namespace Calculadoras
{
    class Program
    {

        static void Main(string[] args) {
            MenuPrincipal();
        }


        static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Escolha um Opção");
            Console.WriteLine("1- Calculadora IMC");
            Console.WriteLine("2- Calculadora Area Circulo");
            Console.WriteLine("3- Calculadora regra de 3");
            Console.WriteLine("4- Sair");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Selecione uma Opção");

            short resposta = short.Parse(Console.ReadLine());

            switch (resposta)
            {
                // Estamos verificando a opção desejada e chamando o metodo. 
                case 1: CalculaIMC(); break;
                case 2: CalculaAreaDoCirculo(); break;
                case 3: CalculaRegraDeTres(); break;
                case 4: System.Environment.Exit(0); break;
                default: MenuPrincipal(); break;
            }
        }



        static void CalculaIMC()
        {
            float imc, peso, altura;

            Console.Clear();

            Console.WriteLine("Insira o seu peso (Kg):");
             peso = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Insira sua altura (M):");
             altura = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

             imc= peso/ (altura * altura);

            Console.WriteLine(imc);
            string resultado = "Resultado= ";

            if (imc < 18.5) resultado+= "A baixo do peso.";
            else if (imc < 24.9) resultado += "Peso Normal.";
            else if (imc < 29.9) resultado += "Excesso de peso."; 
            else if (imc < 35) resultado += "Obesidade.";
            else resultado += "Obesidade extrema.";

            Console.WriteLine(resultado +" IMC: "+ imc.ToString());

            Console.ReadKey();

            MenuPrincipal();

        }


        static void CalculaAreaDoCirculo()
        {
            Console.Clear();
            double areaCirculo, RaioDoCirculo;
            
            Console.WriteLine(" Informe o raio do Círculo: ");
            RaioDoCirculo = double.Parse(Console.ReadLine());
            areaCirculo = Math.PI * Math.Pow(RaioDoCirculo, 2);
            Console.WriteLine("Área do círculo= "+ areaCirculo.ToString("N2"));
            

            Console.ReadKey();
            MenuPrincipal();
        }

        static void CalculaRegraDeTres()
        {

            Console.Clear();
            int a, b, c;
            Console.WriteLine("Insira o valor de A: ");
             a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de C: ");
            c = int.Parse(Console.ReadLine());

            int d = (c * b) / a;
            Console.WriteLine("valor de D: " + d);

            Console.ReadKey();
            MenuPrincipal();

            
        }


    }
}
