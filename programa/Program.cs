/*IF Salario
const decimal salarioMinimo = 1518m;

Console.Write(" Digite o salario do funcionario: R$ ");
decimal salariofuncionario = decimal.Parse(Console.ReadLine());

if (salariofuncionario == salarioMinimo)
{
    Console.WriteLine($"o funcionario recebe o salario minimo {salariofuncionario:C}");
}
else 
{
    Console.WriteLine($"o funcionario  Não recebe o salario minimo{salariofuncionario:C}");
}

*/

using System.Runtime.Intrinsics.X86;

float num1 = 0f;
float num2 = 0f;
string operacaoMatematica;

Console.WriteLine("Informe a operação matematica:\n" +
  " + ou - ou * ou /");
operacaoMatematica = Console.ReadLine();

Console.WriteLine("informe o primeiro valor");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("informe o segundo valor");
num1 = float.Parse(Console.ReadLine());

if (operacaoMatematica == "+")
{
    Console.WriteLine($"soma: {(num1 + num2):F2}");
}
else if (operacaoMatematica == "-")
{
    Console.WriteLine($"soma: {(num1 - num2):F2}");
}
else if (operacaoMatematica == "*")
{
    Console.WriteLine($"soma: {(num1 * num2):F2}");
}
else if (operacaoMatematica == "/")
{
    Console.WriteLine($"soma: {(num1 / num2):F2}");
}
else { Console.WriteLine(" Operação invalida!");}

    // soma, multiplique,subtraia, divide
    Console.WriteLine($"soma: {num1 + num2}");
    Console.WriteLine($"multiplique: {num1 * num2}");
    Console.WriteLine($"divide: {num1 / num2}");
    Console.WriteLine($"subtração: {num1 - num2}");


