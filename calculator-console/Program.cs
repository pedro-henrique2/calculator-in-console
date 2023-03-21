using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("Bem Vindo a calculadora!");
        Console.WriteLine("Por favor digite um numero, seguido de um operador (+, -, *, /), e outro numero");
        Console.WriteLine("Por exemplo: 7 + 3");
        Console.WriteLine("--------------------------------------------------------------------------------");

        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        if (parts.Length != 3)
        {
            Console.WriteLine("Entrada invalida digite novamente.");
            return;
        }

        double num1, num2;

        if (!double.TryParse(parts[0], out num1) || !double.TryParse(parts[2], out num2))
        {
            Console.WriteLine("Numero invalido, por favor tente novamente.");
            return;
        }

        double result;

        switch (parts[1])
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Não é possivel dividir por 0.");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Operador invalido, por favor tente novamente.");
                return;
        }

        Console.WriteLine("O resultado é: " + result);
    }
}
