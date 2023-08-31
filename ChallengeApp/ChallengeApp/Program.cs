var name = "Ewa";
var gender = "kobieta";
var age = 29;

if (age < 30 && gender == "kobieta")
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
 else if (age == 29 + 4 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && gender == "meżczyzna")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
