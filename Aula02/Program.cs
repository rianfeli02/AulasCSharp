


string operacaoMatematica;
float num1 = 0f;
float num2 = 0f;
string opcao;


while (true)
{

    Console.WriteLine("Informe a operação matemática: \n" +
        " +. -, / ou* ");
    operacaoMatematica = Console.ReadLine();

    Console.WriteLine("informe o primeiro valor");
    num1 = float.Parse(Console.ReadLine());

    Console.WriteLine("informe o segundo valor");
    num1 = float.Parse(Console.ReadLine());

    switch (operacaoMatematica)
    {
        case "+":
            Console.WriteLine($"Soma: {(num1 + num2):F2}");
            break;

        case "-":
            Console.WriteLine($"Subtração: {(num1 - num2):F2}");
            break;

        case "/":
            Console.WriteLine($"Divisão: {(num1 / num2):F2}");
            break;

        case "*":
            Console.WriteLine($"Multiplicação: {(num1 * num2):F2}");
            break;


        default:
            Console.WriteLine("informe uma opção valida");
            break;
    }

    Console.WriteLine(" Deseja continar s/n");
    opcao = Console.ReadLine();

    if (opcao != "s")
    {
        break;
    }
    else { Console.WriteLine(0); }


}