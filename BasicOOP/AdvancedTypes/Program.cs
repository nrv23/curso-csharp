
using AdvancedTypes.clasess;
using AdvancedTypes.structs;
//var converter = new ObjectToTextConverter();

//Console.WriteLine(converter.Convert(new Pet("Buddy", PetType.Dog, 12.5f)));


//// usar los atributos personalizados

//var validator = new Validator();
//var person = new Person("Alice", "DS", 1990);
//var person2 = new Person("Alice", "DS", 1990);
//var person3 = new Person("Alice", "DS", 1991);
//Console.WriteLine("Are th same person? " + person.Equals(person2));
//Console.WriteLine("Are th same person? " + person.Equals(person3));
//Console.WriteLine("Are th same person? " + person.Equals(null));
//Console.WriteLine("Are th same person? " + person.Equals(new { }));


//Console.WriteLine($"Is person valid? {validator.validate(person)}");
//var dog = new Dog("DS");
//Console.WriteLine($"Is dog valid? {validator.validate(dog)}");

//var point = new Point(10, 20);
//var point2 = point;

//var point3 = point with { X = 30 }; // crea una copia de point pero con X modificado, de esta forma se pueden modificar 
//structs
//point2.X = 20;
//Console.WriteLine($"sobrecarga de operadores para struct POints + {point + point2}");
//Console.WriteLine($"sobrecarga de operadores para struct POints = {point == point2}");
//Console.WriteLine($"sobrecarga de operadores para struct POints != {point + point2}");
//reestricciones a solo struct en metodos genericos 

//someMethod(point2);
//var time = new Time(10, 1);
//Console.WriteLine(time.ToString());


//var jonh = new Person("John", "Doe", 1980);
//var theSameJonh = new Person("John", "Doe", 1980); // las clases son reference type
//var john2 = jonh; // apunta a la misma referencia en memoria

//Console.WriteLine("Are references equal " + object.ReferenceEquals(jonh, theSameJonh));
//Console.WriteLine("Are references equal " + object.ReferenceEquals(jonh, john2));
//Console.WriteLine("Are  equal " + point.Equals(point2));
//someMethod(new Person()); // da error porque tiene que ser value type

//equals metodo de object type
//void someMethod<T>(T value) where T : struct // indica que T debe ser un struct
//{
//    Console.WriteLine(value.ToString());
//}

//Console.WriteLine(point.ToString());
//Console.WriteLine(point2.ToString());

//var tuple = Tuple.Create(10, 20);
//var point = new Point(10, 20);
//var point2 = new Point(1, 20);
//point = tuple; // conversion implicita de tuple a point


//var time1 = new Time(10,30);
//var time2 = new Time(1, 00);

//var time3 = time1 + time2;

//Console.WriteLine("hashcode point1 " + point.GetHashCode());
//Console.WriteLine("hashcode point2 "+ point2.GetHashCode());

//Console.WriteLine(time3);

var person1 = new Person("John", "Doe", 1980,1);
var person2 = new Person("John", "Doe", 1980, 1);
var person3 = new Person("John", "Doe", 1980, 6);

Console.WriteLine("hashcode person1 " + person1.GetHashCode());
Console.WriteLine("hashcode person2 " + person2.GetHashCode());
Console.WriteLine("hashcode person3 " + person3.GetHashCode());

// declaracion de valuetuples

var valueTple = (Name: "John", Age: 30);    // forma anonima
valueTple.Name = "otro";
Console.WriteLine(valueTple);
var valuetupe2 = new ValueTuple<string, int>("John", 30); // forma explicita    
valuetupe2.Item1 = "Doe";
Console.WriteLine(valuetupe2);

// variables que permiten null

int? numerOrNull = null;

Console.ReadKey();