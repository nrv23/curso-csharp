
using AdvancedTypes.clasess;

var converter = new ObjectToTextConverter();

Console.WriteLine(converter.Convert(new Pet("Buddy", PetType.Dog, 12.5f)));


// usar los atributos personalizados

var validator = new Validator();
var person = new Person("Alice","DS", 1990);
Console.WriteLine($"Is person valid? {validator.validate(person)}");
var dog = new Dog("DS");
Console.WriteLine($"Is dog valid? {validator.validate(dog)}");



Console.ReadKey();