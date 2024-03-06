namespace ATV2_CJ3021912
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1
            Console.WriteLine("exercicio 1");
            int metros, centimetros, milimetros;
            Console.WriteLine("escreva o valor em metros: ");
            metros = int.Parse(Console.ReadLine());
            centimetros = metros * 100;
            milimetros = metros * 1000;
            Console.WriteLine("o seu valor em metros corresponde a: "+ centimetros+ " centimetros e a: "+ milimetros+ " milimetros \n");


            //exercicio 2
            Console.WriteLine("exercicio 2");
            int fahrenheit, celsius;
            Console.WriteLine("insira o valor em fahrenheit: ");
            fahrenheit = int.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) * (5 / 9);
            Console.WriteLine("o valor correspondente em celsius sera: "+ celsius+ "\n a razao que dara 0 sera o de celsius \n");


            //exercicio 3
            Console.WriteLine("exercicio 3");
            float peso, altura, IMC;
            Console.WriteLine("insira seu peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("insira sua altura: ");
            altura = float.Parse(Console.ReadLine());
            IMC = peso / (altura * 2);
            Console.WriteLine("seu IMC é: "+ IMC+ "\n");

            //exercicio 4
            Console.WriteLine("exercicio 4");
            int num1, num2, num3, peso1, peso2, peso3, media;
            Console.WriteLine("insira o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o terceiro numero: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o primeiro peso: ");
            peso1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o segundo peso: ");
            peso2 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o terceiro peso: ");
            peso3 = int.Parse(Console.ReadLine());
            media = num1 + num2 + num3 + peso1 + peso2 + peso3 / 6;
            Console.WriteLine("a media de todos esses numeros é: "+ media+ "\n");

            //exercicio 5
            Console.WriteLine("exercicio 5");
            int frequencia, comprimento, velocidade;
            Console.WriteLine("insira a frequencia da onda: ");
            frequencia = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o comprimento da onda: ");
            comprimento = int.Parse(Console.ReadLine());
            velocidade = frequencia * comprimento;
            Console.WriteLine("a velocidade da sua onda é de: "+ velocidade+ "\n");


            
            //exercicio 6
            float salario, aumento, divisao;

            Console.WriteLine("exercicio 6");
            Console.WriteLine("qual o valor do salario?");
            salario = float.Parse(Console.ReadLine());
            aumento = salario * 25;
            divisao = aumento / 100;
            Console.WriteLine("seu novo salario é: {0}", divisao+ "\n");

            //exercicio 7
            Console.WriteLine("exercicio 7");
            int real, dolar = 5, valor;
            Console.WriteLine("insira o valor em real: ");
            real = int.Parse(Console.ReadLine());
            valor = real * dolar;
            Console.WriteLine("seu valor em real corresponde a: "+ valor+ " dolares\n");



            //exercicio 8
            Console.WriteLine("exercicio 8");
            int numero, sucessor, triplo, antecessor, dobro, soma;
            Console.WriteLine("escreva o numero: ");
            numero = int.Parse(Console.ReadLine());
            triplo = numero * 3;
            sucessor = triplo + 1;
            dobro = numero * 2;
            antecessor = dobro - 1;
            soma = sucessor + antecessor;
            Console.WriteLine("a soma do sucessor do triplo do seu numero com o antecessor do dobro do seu numero é: {0}", soma+ "\n");


            //exercicio 10
            Console.WriteLine("exercicio 10");
            float valor_inicial = 1000, primeiro_dia, segundo_dia, terceiro_dia, quarto_dia, valor_atual;

            primeiro_dia = valor_inicial - (3.4f / 100) * valor_inicial;
            segundo_dia = primeiro_dia + (2.8f / 100) * primeiro_dia;
            terceiro_dia = segundo_dia + (14 / 100) * segundo_dia;
            quarto_dia = terceiro_dia - (8.5f / 100) * terceiro_dia;
            valor_atual = quarto_dia;
            Console.WriteLine("o valor atual dos investimentos de marquesito é: {0}", valor_atual+ "\n");

            //exercicio 11
            Console.WriteLine("exercicio 11")   
            int num, quadrado, cubo;
            Console.WriteLine("insira o valor do numero: ");
            num = int.Parse(Console.ReadLine());
            quadrado = num * num;
            cubo = num * num * num;
            Console.WriteLine("o valor do seu numero ao quadrado é: "+ quadrado+ " e "+  cubo+ " ao cubo\n");

            //exercicio 12
            Console.WriteLine("exercicio 12");
            double h, Peso, homen, nulher;
            string genero;
            Console.WriteLine("qual a sua altura?");
            h = float.Parse(Console.ReadLine());
            homen = (72.7 * h) - 58.0;
            nulher = (62.1 * h) - 44.7;
            Console.WriteLine("qual o seu genero?");
            genero = Console.ReadLine();
            if (genero == homem)
            {
                Console.WriteLine("o seu peso ideal é de: " + homen + "\n");
            }
            if (genero == mulher) 
            {
                Console.WriteLine("o seu peso ideal é de: " + nulher + "\n");
            }

            //exercicio 13
            Console.WriteLine("exercicio 13\n");
            Console.WriteLine("o github é um site em que varios desenvolvedores compartilham programas, os comandos do github sao: git branch, git clone, git checkout, git status, git add, git commit, git push, git pul, git help e git config");
        }
    }
}



