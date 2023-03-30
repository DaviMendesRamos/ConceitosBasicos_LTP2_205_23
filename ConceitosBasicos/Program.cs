// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World!");
string nome = "Davi";
Console.WriteLine("Seja Bem vindo" + nome);
string cidade = "Pinheiral";
Console.WriteLine("Eu gosto de " + cidade);

Console.WriteLine("Digite sua idade");
string idade = Console.ReadLine();
Console.WriteLine($"sua idade é {idade}");

byte valor = 255;
valor += 1; //valor = valor + 1;
Console.WriteLine($"valor : {valor}");

decimal salario = 5000.20m;
// como seria a declaração mais adequada para variaveis que armazenem altuta, peso e altura em nanometros.

Console.WriteLine("digite sua altura");
float altura = float.Parse(Console.ReadLine());
double altura2 = altura * 0.000000001;
Console.WriteLine($"A sua altura é {altura}");
Console.WriteLine($"A sua altura em nanometro é {altura2}");
Console.WriteLine("Digite o peso");
int peso = int.Parse(Console.ReadLine());
Console.WriteLine($"O peso informado foi: {peso}");


int val1 = 32, result;

result = 10 + val1++; Console.WriteLine(result); //42
result = 10 + ++val1; Console.WriteLine(result);//44

