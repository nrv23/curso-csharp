// See https://aka.ms/new-console-template for more information

using TodoListProject.clasess;
using TodoListProject.classes;


string menuOption;
string userInput;
bool isValidInput;
int idx;
bool result;
List<string> list = new List<string>();
string currentTodo;

ValidatorUserInput validator = new ValidatorUserInput();
TodoList todoList = new TodoList();

int isValidIndex(string index)
{
    return validator.processUserInput(index) ?? 0;
}

void main ()
{


    Console.WriteLine("Todo List App");

   

    do
    {

        Console.WriteLine("A) Add Todo");
        Console.WriteLine("L) List Todos");
        Console.WriteLine("R) Remove Todo");
        Console.WriteLine("G) Get Todo");
        Console.WriteLine("E) Exit");

        Console.WriteLine("Enter an option");
        menuOption = Console.ReadLine();

        char.TryParse(menuOption, out char option);

        isValidInput = validator.IsValidMenuOption(option);

        if (!isValidInput)
        {
            Console.WriteLine("Opción inválida");
        }

        else if (isValidInput && option != 'e')
        {
            switch (option)
            {
                case 'a':

                    Console.WriteLine("Enter todo:");
                    userInput = Console.ReadLine();

                    list = todoList.GetAllTodos();

                    if(list.Contains(userInput))
                    {
                        Console.WriteLine("Ya existe un todo con esa descripcion");
                    } else
                    {
                        result = todoList.AddTodo(userInput);

                        if (!result)
                        {
                            Console.WriteLine("No se pudo agregar el todo");
                        }
                        else
                        {
                            Console.WriteLine("Se agregó el todo con éxito");
                        }
                    }
                    

                    break;
                case 'r':

                    if(list.Count == 0)
                    {
                        Console.WriteLine("No hay todos en la lista");
                    } else
                    {
                        Console.WriteLine(" Enter todo index");
                        userInput = Console.ReadLine();
                        idx = isValidIndex(userInput);
                        if (idx == 0)
                        {
                            Console.WriteLine("indice inválido");
                        }
                        else
                        {
                            result = todoList.RemoveTodo(idx - 1);

                            if (result) Console.WriteLine("Se ha eliminado el todo");
                            else Console.WriteLine("El índice no existe");
                        }
                    }

                    
                    break;

                case 'l':
                    list = todoList.GetAllTodos();
                    if (list.Count == 0) Console.WriteLine("No hay todos en la lista");
                    list.Select((value, index) => $"[{index + 1}] {value}")
                        .ToList()
                        .ForEach(Console.WriteLine);
                    break;
                case 'g':
                    Console.WriteLine(" Enter todo index");
                    userInput = Console.ReadLine();
                    idx = isValidIndex(userInput);
                    if (idx == 0)
                    {
                        Console.WriteLine("indice inválido");
                    }  
                    else
                    {
                        Console.WriteLine(todoList.GetTodoById(idx - 1));
                    }

                    break;
            }
        }



    } while (!isValidInput || menuOption != "e");


    Console.WriteLine("Ha abandonado la aplicación");


    Console.ReadKey();
}

main();