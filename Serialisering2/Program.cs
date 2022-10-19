using System.IO;
using System.Text.Json;


Charm cha = new Charm()
{
    PickedUp = false,
    IsEquipped = false,
    Name = "Sprint Master",
    Price = 1
};

bool select = true;

while(select)
{
    select = false;
    Console.WriteLine("You find a charm on the floor. Do you pick it up?\ny/n");
    string choice = Console.ReadLine();
    switch(choice)
    {
        case "y":
            cha.PickedUp = true;
            Console.WriteLine("Congrats!! You did it!!\nGame Over");
            break;
        case "n":
            Console.WriteLine("You ignore the charm and move along with your day.\nGameOver");
            break;
        default:
            select = true;
            Console.WriteLine("That was not even an option. What are you even doing?\nJust type 'y' or 'n'.");
            break;
    }
}

string chaText = JsonSerializer.Serialize<Charm>(cha);

File.WriteAllText("Charm.json", chaText);

Console.WriteLine("\n"+chaText);

Console.ReadLine();