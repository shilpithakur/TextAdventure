using System;
namespace TextAdventure
{
    public class Game
    {
        string playerName = "";
        string playerChoice = "";
        int dinoHealth = 1000;
        int dinoAttack = 20;
        int playerHealth = 2000;
        int playerAttack = 50;


        public Game()
        {
        }

        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to Treasure hunt Game. \nYou have to defeat the dinosaurs - part1 (Current Game) \n Cross a river - part 2 (coming soon)\n Solve a riddle within 1 minute to win this game- part 3 (coming soon)");
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("Whats your name: ");
            playerName = Console.ReadLine();
            Console.WriteLine($"Hello {playerName}, Let's play!");

            Console.WriteLine("Press any key to start");
            Console.ReadLine();


        }

        public void Fight()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You are in a jungle with dinosaurs around you. you have to pick a dinosaur you want to fight. \n Enter (T) for T-Rex \n Enter (R) for Raptor \n Enter (TT) for TriceraTops \n Enter (C) for Carnotaurus");
            Console.ForegroundColor = ConsoleColor.Black;
            string DinoChoice = Console.ReadLine().ToLower();

            switch(DinoChoice)
            {
                case "t":
                    Console.WriteLine("You'll fight a T-Rex. Get Ready");
                    break;

                case "r":

                    Console.WriteLine("You'll fight a Raptor. Get Ready");
                    break;

                case "tt":
                    Console.WriteLine("You'll fight a Triceratops. Get Ready");
                    break;

                case "c":
                    Console.WriteLine("You'll fight a Carnotaurus. Get Ready");
                    break;

                default:
                    Console.WriteLine("Invalid entry");
                    break;


            }
            Console.WriteLine($"The dinosaur has {dinoHealth} healthpoints left");
            Console.WriteLine($"You have {playerHealth} healthpoins left");

            do
            {
                Console.WriteLine("The dinosaur is approaching you!! Will you (A)ttack or (D)efend? ");
                playerChoice = Console.ReadLine();

                if (playerChoice == "a")
                {
                    
                    Console.WriteLine("Attack the dino!!");

                    //Attack();
                    Random rand1 = new Random();
                    int numOfAttacksByPlayer = rand1.Next(1, 4);

                    for (int i = 0; i <= numOfAttacksByPlayer; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou Attack");
                    }
                    Console.ForegroundColor = ConsoleColor.Black;
                    int dinoDamage = numOfAttacksByPlayer * playerAttack;
                    dinoHealth = dinoHealth - dinoDamage;
                    Console.WriteLine($"You attacked the dinosaur for {dinoDamage} damagePoints");
                    Console.WriteLine($"Dinosaur has {dinoHealth} healthPoints left");

                    Console.WriteLine("The Monster attacks back");
                    Random rand2 = new Random();
                    int numOfAttacksByMonster = rand2.Next(1,3);
                    for (int i = 0; i<= numOfAttacksByMonster; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nMonster Attack");
                    }
                    Console.ForegroundColor = ConsoleColor.Black;
                    int playerDamage = numOfAttacksByMonster * dinoAttack;
                    playerHealth = playerHealth - playerDamage;
                    Console.WriteLine($"You took {playerDamage} damagePoints hits from the dinosaur");
                    Console.WriteLine($"You haveh {playerHealth} healthPoints left");
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    
                }


                else if (playerChoice == "d")
                {
                    Console.WriteLine("Defend Yourself from the dino!!");
                    //Defend();
                    Random rand3 = new Random();
                    int numOfAttacksByMonster = rand3.Next(2, 4);
                    for (int i = 0; i <= numOfAttacksByMonster; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nMonster Attack");
                    }
                    Console.ForegroundColor = ConsoleColor.Black;
                    int playerDamage = numOfAttacksByMonster * dinoAttack;
                    playerHealth = playerHealth - playerDamage;
                    Console.WriteLine($"You took {playerDamage} damagePoints hits from the dinosaur");
                    Console.WriteLine($"You haveh {playerHealth} healthPoints left");

                    Random rand4 = new Random();
                    int numOfAttacksByPlayer = rand4.Next(2, 5);
                    for (int i = 0; i <= numOfAttacksByPlayer; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou Attack Back");
                    }
                    Console.ForegroundColor = ConsoleColor.Black;
                    int dinoDamage = numOfAttacksByPlayer * playerAttack;
                    dinoHealth = dinoHealth - dinoDamage;
                    Console.WriteLine($"You attacked the dinosaur for {dinoDamage} damagePoints");
                    Console.WriteLine($"Dinosaur has {dinoHealth} healthPoints left");
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                }

            }while (playerHealth > 0 && dinoHealth > 0);



            if (playerHealth <= 0)
            {
                Console.WriteLine("You Lost :(");
            }
            else if (dinoHealth <= 0)
            {
                Console.WriteLine("YOU WON !!!!!");
            }


        }


        //public void Attack()
        //{
            
        //        Random rand1 = new Random();
        //        int numOfAttacksByPlayer = rand1.Next(2, 5);
        //        for (int i = 0; i == numOfAttacksByPlayer; i++)
        //        {
        //            Console.WriteLine("You Attack");
        //        }
        //        int dinoDamage = numOfAttacksByPlayer * playerAttack;
        //        dinoHealth = dinoHealth - dinoDamage;
        //        Console.WriteLine($"You attacked the dinosaur for {dinoDamage} damagePoints");
        //        Console.WriteLine($"Dinosaur has {dinoHealth} healthPoints left");

        //        Console.WriteLine("The Monster attacks back");
        //        Random rand2 = new Random();
        //        int numOfAttacksByMonster = rand2.Next(2, 4);
        //        for (int i = 0; i == numOfAttacksByMonster; i++)
        //        {
        //            Console.WriteLine("Monster Attack");
        //        }
        //        int playerDamage = numOfAttacksByMonster * dinoAttack;
        //        playerHealth = playerHealth - playerDamage;
        //        Console.WriteLine($"You took {playerDamage} damagePoints hits from the dinosaur");
        //        Console.WriteLine($"You haveh {playerHealth} healthPoints left");


        //}

        //public void Defend()
        //{
            
        //        Random rand3 = new Random();
        //        int numOfAttacksByMonster = rand3.Next(2, 4);
        //        for (int i = 0; i == numOfAttacksByMonster; i++)
        //        {
        //            Console.WriteLine("Monster Attack");
        //        }
        //        int playerDamage = numOfAttacksByMonster * dinoAttack;
        //        playerHealth = playerHealth - playerDamage;
        //        Console.WriteLine($"You took {playerDamage} damagePoints hits from the dinosaur");
        //        Console.WriteLine($"You haveh {playerHealth} healthPoints left");

        //        Random rand4 = new Random();
        //        int numOfAttacksByPlayer = rand4.Next(2, 5);
        //        for (int i = 0; i == numOfAttacksByPlayer; i++)
        //        {
        //            Console.WriteLine("You Attack Back");
        //        }
        //        int dinoDamage = numOfAttacksByPlayer * playerAttack;
        //        dinoHealth = dinoHealth - dinoDamage;
        //        Console.WriteLine($"You attacked the dinosaur for {dinoDamage} damagePoints");
        //        Console.WriteLine($"Dinosaur has {dinoHealth} healthPoints left");


        //}       
            

    }
}
