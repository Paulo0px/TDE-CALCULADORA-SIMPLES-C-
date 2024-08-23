
Console.WriteLine("Digite o primeiro número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double soma = num1 + num2;
double subtracao = num1 - num2;
double divisao = num1 / num2;
double multiplicacao = num1 * num2;

//usando concatenação
Console.WriteLine("A soma é: " + soma);

//usando interpolação
Console.WriteLine($"A subtração é: {subtracao}");

//usando placeholders
Console.WriteLine("A divisão é: {0}", divisao);
Console.WriteLine("A multiplicação é: {0}", multiplicacao);


