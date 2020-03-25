using System;
using System.Threading;

namespace Bullet_Hell
{
    class Program
    {
        static void Main(string[] args)
        {
            int window_x = 50;
            int window_y = 20;
            Console.SetWindowSize(window_x, window_y);

            Player Dovah = new Player(25, 18, 5, "[Player]"); // TEST
            Enemy Imperial_scum = new Enemy(25, 5, "[Enemy]"); // TEST

            Thread enemy_movement = new Thread(Imperial_scum.movement); // Thread created cause movement uses thread.sleep()
            Thread Player_Enemy_movements = new Thread(()=>movements(Dovah, Imperial_scum)); // To update and render enemy and player at the same time
            enemy_movement.Start();
            Player_Enemy_movements.Start();
            Dovah.input(); // Player movement

            Console.ReadLine();
        }

        public static void movements(Player Dovah, Enemy Imperial_scum) // /---/ Without the trigger and movements() movement would be fine, but would only show for the player and not the enemy
        {

            ConsoleKeyInfo cki;
            while (true)
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.W || cki.Key == ConsoleKey.A || cki.Key == ConsoleKey.S || cki.Key == ConsoleKey.D || 
                    cki.Key == ConsoleKey.UpArrow || cki.Key == ConsoleKey.LeftArrow || cki.Key == ConsoleKey.DownArrow || cki.Key == ConsoleKey.RightArrow)
                {
                    Console.WriteLine(Dovah.character); // input every 2nd ReadKey()?.. /---/ CONSOLE CAN ONLY TAKE 1 CURSOR POSITION AT A TIME AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                    Console.WriteLine(Imperial_scum.enemy); // input every 2nd ReadKey()?.. /---/ CONSOLE CAN ONLY TAKE 1 CURSOR POSITION AT A TIME AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                }
            }
            // So both character and enemy updates at the same time, and is rendered at the same time
        }
    }
}

    // -----------------------------------------------------------------------------------------------------------------------------------------------------------------

    // ----- PROBLEM -----

    // The Enemy position on the console and the Player position on the console always seemed to be around the same place and "depend" on each other
    // Such as, if the Player moved upwards, the Enemy would follow, even though it wasn't programmed to do so



    // ----- OBSERVATIONS -----

    // Imperial_scum.enemy didn't seem to move / was stuck to Dovah.character, because by far most of the times, the Dovah.character cursor would be set
    // and printed out whenever you pressed something (W, A, S, D, Arrowkeys)

    // If you held one of the keys down, you would notice that the position sometimes prints out at the enemy's cursor position instead of the player's, so
    // the enemy cursor position does work correctly. But it can't print both of the cursor positions out at once
    // (Enemy cursor position was running in a thread with a few seconds delay)
    // This obviously also meant, that if the enemy cursor position was set, the player would automatically teleport to the enemy's position for a split second



    // ----- POSSIBLE SOLUTIONS ----- 

    // Using Console.SetCursorPosition(x,y) for Enemy AND Player could've possibly worked if it was possible to have multiple cursors in the console

    // If it was possible to make a variable for Player cursor and Enemy cursor, things might have turned out working as well, since it would save 
    // each position in the memory and print each position out, followed by a Console.Clear() repeatedly



    // ----- CONCLUSION -----

    // I fucked up

    // Thank you for attending my TED Talk