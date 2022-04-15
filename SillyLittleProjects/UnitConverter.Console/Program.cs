// See https://aka.ms/new-console-template for more information

Console.Title = "UnitConverter.Console | by RayuDW";

Console.WriteLine("Convert what?");
Console.WriteLine("(1) Lenght - cm in inches");
Console.WriteLine(" * placeholder *");
Console.WriteLine(" * placeholder *");
Console.WriteLine(" * placeholder *");
Console.Write("> ");

bool validInput = int.TryParse(Console.ReadLine(), out int result);

if (result == 1)
{
        Console.WriteLine("How many cm?");
        Console.Write("> ");
        bool validDoubleInput = double.TryParse(Console.ReadLine(), out double cmToConvert);

        if (validDoubleInput)
        {
                double convertedInchValue = cmToConvert / 2.54;
                Console.WriteLine($"That are {convertedInchValue} inch!");
        }
}

else
{
        Console.WriteLine("Error!");
}