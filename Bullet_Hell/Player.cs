using System;
using System.Collections.Generic;
using System.Text;

namespace Bullet_Hell
{
    public class Player
    {
        public int player_position_x { get; set; } = 25;
        public int player_position_y { get; set; } = -18;
        public int speed { get; set; } = 0;
        public string character { get; set; } = "|__uwu__|";

        public Player(int pos_x, int pos_y, int speed, string character = "|__uwu__|")
        {
            player_position_x = pos_x;
            player_position_y = pos_y;
            this.speed = speed;
            this.character = character;
        }

        public void collision()
        {

        }

        public void input() // For some reason, the player_position_x = 0 starts at like x position 20. So the maximum range for x is really something like 70 *shrug*
        {
            bool quit = false;
            while (quit == false)
            {
                ConsoleKeyInfo key_input = Console.ReadKey(true);

                if (key_input.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Quit?\nY/N");
                    while (true)
                    {
                        ConsoleKeyInfo keyy_input = Console.ReadKey(true);
                        if (keyy_input.Key == ConsoleKey.Y)
                        {
                            Console.WriteLine("Quitting...");
                            quit = true;
                            break;
                        }
                        if (keyy_input.Key == ConsoleKey.N)
                        {
                            Console.WriteLine("N");
                            break;
                        }
                    }
                }
                if (key_input.Key == ConsoleKey.UpArrow || key_input.Key == ConsoleKey.W)
                {
                    player_position_y -= 1; // ------------------------------------------------------------------------------ Needs fixing
                    if (player_position_y <= 0)
                    {
                        player_position_y += 1;
                    }
                    Console.Clear();
                    Console.SetCursorPosition((25 - character.Length) / 2 + player_position_y + player_position_x, Console.CursorTop = player_position_y);
                    Console.WriteLine(character);
                }
                if (key_input.Key == ConsoleKey.LeftArrow || key_input.Key == ConsoleKey.A)
                {
                    player_position_x -= 1;
                    if (player_position_x <= 0)
                    {
                        player_position_x += 1;
                    }
                    Console.Clear();
                    Console.SetCursorPosition((25 - character.Length) / 2 + player_position_x + player_position_y, Console.CursorTop + player_position_y);
                    Console.WriteLine(character);
                }
                if (key_input.Key == ConsoleKey.DownArrow || key_input.Key == ConsoleKey.S)
                {
                    player_position_y += 1; // ------------------------------------------------------------------------------ Needs fixing
                    if (player_position_y >= 20)
                    {
                        player_position_y -= 1;
                    }
                    Console.Clear();
                    Console.SetCursorPosition((25 - character.Length) / 2 + player_position_y + player_position_x, Console.CursorTop = player_position_y);
                    Console.WriteLine(character);
                }
                if (key_input.Key == ConsoleKey.RightArrow || key_input.Key == ConsoleKey.D)
                {
                    player_position_x += 1;
                    if (player_position_x >= 50)
                    {
                        player_position_x -= 1;
                    }
                    Console.Clear();
                    Console.SetCursorPosition((25 - character.Length) / 2 + player_position_x + player_position_y, Console.CursorTop + player_position_y);
                    Console.WriteLine(character);
                }
            }
        }
    }
}
