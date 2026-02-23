using Player;
using Savable;
using SaveManagers;
using Item;
using System.ComponentModel.Design;
public class program
{
    static void Main()
    {
        Console.WriteLine("1. New player");
        Console.WriteLine("2. Load Player");

        string choice = Console.ReadLine();

        Players player;

        if (choice == "1")
        {
            Console.Write("Choose the name of your player");
            string name = Console.ReadLine();
            player = new Players(name);

            Items item1 = new Items("sword", 1);
            Items item2 = new Items("health potion", 5);

            player.AddItem(item1);
            player.AddItem(item2);

            SaveManager.Save(player, @"C:\\Users\\luisc\\source\\repos\\RPG-Save-System\\RPG Save System\\players.txt");



        }
        else if (choice == "2")
        {
            player = SaveManager.Load<Players>(@"C:\\Users\\luisc\\source\\repos\\RPG-Save-System\\RPG Save System\\players.txt");
            if (player == null)
            {
                Console.WriteLine("There is no player saved");
                return;
            }
            Console.WriteLine("Player found");

        }
        else
        {
            Console.WriteLine("invalid option");
            return;
        }
        Console.WriteLine("Name: " + player.Name);
        Console.WriteLine("Level: " + player.Level);
        Console.WriteLine("Health: " + player.Health);

        Console.WriteLine("Inventory:");
        foreach (var item in player.inventory)
        {
            Console.WriteLine(item.Name + " x " + item.Quantity);
        }
        player.TakeDamage(20);
        player.LevelUp();

        SaveManager.Save(player, @"C:\\Users\\luisc\\source\\repos\\RPG-Save-System\\RPG Save System\\players.txt");

        Console.WriteLine("After damage and level up:");
        Console.WriteLine("Level: " + player.Level);
        Console.WriteLine("Health: " + player.Health);
    }
}