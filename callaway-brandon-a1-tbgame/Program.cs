// PERSONAL TESTING SANDBOX, NOT ACTUAL ASSIGNMENT
using System;



public class Program
{

    public static void Main()
    {
        // Player variables
        string player_name = "TEST";   //Player character name
        int player_health = 100;       //Player health
        int player_action_points = 0;  //Player Action Points
        int player_luck = 0;           //Player Luck
        int player_melee_damage = 10;  //Player melee damage
        int player_ranged_damage = 9;  //Player ranged damage
        int player_gold = 0;           //Player gold
        string player_equipped_trinket = "TESTRINKET"; //Player's currently Equipped Trinket
        int player_room_count = 0;     //Rooms player has entered

        string player_class = "TESTCLASS"; //Player Class

        string splashTextIntro = "SPLASH TEXT HERE";

        string[] player_stats = { player_name, player_health.ToString(), player_action_points.ToString(), player_luck.ToString(), 
                                    player_melee_damage.ToString(), player_ranged_damage.ToString(), player_gold.ToString(), 
                                    player_equipped_trinket, player_class.ToString(), player_room_count.ToString() };


        // Game Loop
        while (true)
        {
            PlayIntro(splashTextIntro);
        }

        // Beginning of game, display splash screen
        void PlayIntro(string splash)
        {
            Console.Clear();
            Console.WriteLine(splash);
            Console.WriteLine("Welcome Coward... Dare to endevour the night?\n Type \"start\" or \"exit\"");

            // Get input from the user
            string player_input = Console.ReadLine();


            // If input is start, move to next scene
            // If input is exit, close the application
            if (player_input == "start")
            {
                player_room_count++;
                PlayActOne();
            }
            else if (player_input == "exit")
            {
                _DEBUG_PLAYER_STAT_CHECK();
                _DEBUG_APP_EXIT();
            }
        }

        void PlayActOne()
        {
            _DEBUG_ROOM_CHECK();
            _DEBUG_APP_EXIT();
        }


        // TODO: GET THIS WORKING DUMMY!!!
        void _DEBUG_PLAYER_STAT_CHECK()
        {
            for (int i = 0; i < player_stats.Length; i++)
            {
                Console.WriteLine($"{player_stats[i]} = {player_stats[i]}");
            }
        }

        void _DEBUG_ROOM_CHECK()
        {
            Console.WriteLine($"DEBUG ROOM COUNT {player_room_count}");
        }

        void _DEBUG_APP_EXIT()
        {
            System.Environment.Exit(0);
        }
    }





}











