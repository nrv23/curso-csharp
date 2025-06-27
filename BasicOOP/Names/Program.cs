using Names.classes;


var names = new ListNames();
var path = NamesFilePathBuilder.BuildFilePath();
var namesRepository = new StringTextualRepository();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    var stringsFromFile = namesRepository.Read(path);
    names.AddNames(stringsFromFile);
    namesRepository.Write(path, names.Names);
}
else
{
    Console.WriteLine("Names file does not yet exist.");

    //let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to the file.");
    namesRepository.Write(path, names.Names);
}

Console.WriteLine("Names in the file:");

Console.WriteLine(NamesFormatter.Format(names.Names));

Console.ReadKey();