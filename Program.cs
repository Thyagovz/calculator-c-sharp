namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 = Soma");
        Console.WriteLine("2 = Subtração");
        Console.WriteLine("3 = Multiplicação");
        Console.WriteLine("4 = Divisão");

        Console.WriteLine("---------------");
        Console.WriteLine("Selecione uma opção: ");
        short res = short.Parse(Console.ReadLine());
    }
    static void Addition()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = v1 + v2;
        Console.WriteLine($"O resultado da soma é {result}");
        Console.ReadKey();
        // Console.WriteLine("O resultado da soma é " + resultado);
        // Console.WriteLine($"O resultado da soma é {v1 + v2}");
        // Console.WriteLine("O resultado da soma é " + (v1 + v2));
    }

    static void Subtraction()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = v1 - v2;
        Console.WriteLine($"O resultado da subtração é {result}");
        Console.ReadKey();
    }

    static void Division()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = v1 / v2;
        Console.WriteLine($"O resultado da divisão é {result}");
        Console.ReadKey();
    }

    static void Multiply()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = v1 * v2;
        Console.WriteLine($"O resultado da divisão é {result}");
        Console.ReadKey();
    }
}

