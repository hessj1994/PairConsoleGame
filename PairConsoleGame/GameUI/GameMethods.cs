using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameUI
{
    public class GameMethods
    {
        private readonly ProgramRepo _gameRepo = new ProgramRepo();

        public void Run()
        {
            _gameRepo.CreateCharacterProperties();
            _gameRepo.CreateEnemyProperties();
            StartGame();
        }

        private void StartGame()
        {

            //Declare the variables: lives, experience points, lose/exit condition(), any data that will globally for all characters
            int startLives = 7; //Starting lives
            int startingExperiencePoints; //starting "points"
            string spawnPoint = "Skyrim";

            List<CharacterProperties> charProps = new List<CharacterProperties>();
            charProps = _gameRepo.ShowCharacterProperties();

            List<EnemyProperties> enemyProps = new List<EnemyProperties>();
            enemyProps = _gameRepo.ShowEnemyProperties();


            // instead of locations, as of right now we're just setting combat
            string characterSelection = "What type of doooood would you like to be?\n";
            string enemySelection = "What type of enemy would you like to fight?\n";

            foreach (CharacterProperties showUserCharAtrributes in charProps)
            {
                characterSelection +=
                    $" {showUserCharAtrributes.CharacterID} --- {showUserCharAtrributes.CharacterName}\n";
            }

            foreach (EnemyProperties showEnemyAttributes in enemyProps)
            {
                enemySelection +=
                    $" {showEnemyAttributes.EnemyID} --- {showEnemyAttributes.EnemyName}\n";
            }

            while (startLives > 0/* && bossKilled != true*/)
            {
                CharacterProperties showCharInfo = new CharacterProperties();
                int userSelectsCharacter;
                string selectionForCharacterType = "";


                bool leaveLoop = false;
                while (!leaveLoop)
                {
                    Console.WriteLine($"TITLE PLACEHOLDER - The Eldest Bewks, Ladryn. But show the user starting stats etc.\n" +
                                      $"Starting location\n" +
                                      $"The beginning of the game starts in {spawnPoint}...");
                    selectionForCharacterType = Console.ReadLine();
                   // userSelectsCharacter = Convert.ToInt32(selectionForCharacterType);
                    //NULL EXCEPTION HANDLER, STRING EXCEPTION HANDLER
                    //if (....

                    if (!int.TryParse(selectionForCharacterType, out userSelectsCharacter))
                    {
                        Console.WriteLine("");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    foreach (CharacterProperties raceCharacterProperties in charProps)
                    {
                        if (userSelectsCharacter == raceCharacterProperties.CharacterID)
                        {
                            leaveLoop = true;
                            showCharInfo = raceCharacterProperties;
                            break;
                        }
                    }
                } //leaving while loop


                Console.WriteLine($"You are a {showCharInfo.CharacterName}.\n" +
                                  $"You have {showCharInfo.Lives} lives.");
            }

            ////user exit condition, if loop
            //if ()
            //{

            //}

            // Get enemy method (need enemy health, determine when its "ded"

            //while ()
            //{
            //    EnemyProperties showEnemyInfo = new EnemyProperties();

            //    Console.WriteLine($"TITLE PLACEHOLDER - The Eldest Bewks, Ladryn. But show the user starting stats etc.\n" +
            //                      $"Starting location\n" +
            //                      $"The beginning of the game starts in {spawnPoint}...");
            //    selectionForCharacterType = Console.ReadLine();
            //    userSelectsCharacter = Convert.ToInt32(selectionForCharacterType);
            //    //NULL EXCEPTION HANDLER, STRING EXCEPTION HANDLER
            //    //if (....

            //    foreach (CharacterProperties raceCharacterProperties in charProps)
            //    {
            //        if (userSelectsCharacter == raceCharacterProperties.CharacterID)
            //        {
            //            leaveLoop = true;
            //            showCharInfo = raceCharacterProperties;
            //            break;
            //        }
            //    }
            //}


            // writeline if you kill/do not kill said bitch ass enemy





            //Console.ReadLine();
        }
    }
}
