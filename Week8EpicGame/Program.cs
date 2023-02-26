string folderPath = @"E:\MicrosoftVisualStudio\ProgrammerimiseAlgkursus\Tööd\DATA\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

//string[] heroes = { "Harry potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villians = { "Voldemort", "Darthvade", "Dracula", "Joker", "Sauron" };
string[] weapon = { "Magic wand", "Fork", "Banana", "Wooden sword", "Brick" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villians);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"{villain} with {villainWeapon} tries to take over the world!");


static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length );
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}