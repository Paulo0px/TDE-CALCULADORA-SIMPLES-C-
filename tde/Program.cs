
Console.WriteLine("Digite o primeiro número: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int soma = num1 + num2;
int subtracao = num1 - num2;
int divisao = num1 / num2;
int multiplicacao = num1 * num2;

//usando concatenação
Console.WriteLine("A soma é: " + soma);

//usando interpolação
Console.WriteLine($"A subtração é: {subtracao}");

//usando placeholders
Console.WriteLine("A divisão é: {0}", divisao);
Console.WriteLine("A multiplicação é: {0}", multiplicacao);


