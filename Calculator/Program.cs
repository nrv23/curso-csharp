using Calculator.classes;

void main()
{
    Console.WriteLine("Bienvenido al programa calculadora");

    ValidatorUserInput validatorUserInput = new ValidatorUserInput();
    DataParser parser = new DataParser();
    Calculate calculator = new Calculate();

    bool isValidOption;
    int number1, number2, result;
    string response;
    string option;
    string userInput;

    do
    {
        Console.WriteLine("Seleccione una opción");
        Console.WriteLine("S - Sumar");
        Console.WriteLine("R - Restar");
        Console.WriteLine("M - Multiplicar");
        Console.WriteLine("D - Dividir");
        Console.WriteLine("E - Exit");

        option = Console.ReadLine().ToLower();
        isValidOption = validatorUserInput.IsValidMenuOption(char.Parse(option));

        if(!isValidOption && option != "e")
        {
            Console.WriteLine("Opción inválida");
        }

        else if (option != "e" && isValidOption)
        {
            Console.WriteLine("Dame un número");
            userInput = Console.ReadLine();
            number1 = validatorUserInput.processUserInput(userInput);

            Console.WriteLine("Dame un segundo número");
            userInput = Console.ReadLine();
            number2 = validatorUserInput.processUserInput(userInput);

            if (number1 == 0 || number2 == 0)
            {
                Console.WriteLine("Número inválidos");
            }
            else
            {
                result = calculator.ProcessOperation(number1, number2, char.Parse(option));
                response = parser.ParseResponse(number1, number2, result, char.Parse(option));
                Console.WriteLine(response);
            }
        } 

        

    } while (option != "e");
    Console.WriteLine("Has salido del programa calculadora");
    Console.ReadKey();
}

main();
