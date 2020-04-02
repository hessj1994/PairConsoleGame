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
            int startingExperiencePoints = 0; //starting "points"
            string spawnPoint = "Skyrim";
            //bool exitCondition != false;

            List<CharacterProperties> charProps = new List<CharacterProperties>();
            charProps = _gameRepo.ShowCharacterProperties();
            // instead of locations, as of right now we're just setting combat
            string characterSelection = "What type of doooood would you like to be?\n";

            foreach (CharacterProperties showUserCharAtrributes in charProps)
            {
                characterSelection +=
                    $" {showUserCharAtrributes.CharacterID} --- {showUserCharAtrributes.CharacterName}\n";
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
                    userSelectsCharacter = Convert.ToInt32(selectionForCharacterType);
                    //NULL EXCEPTION HANDLER, STRING EXCEPTION HANDLER
                    //if (....

                    foreach (CharacterProperties raceCharacterProperties in charProps)
                    {
                        if (userSelectsCharacter == raceCharacterProperties.CharacterID)
                        {
                            leaveLoop = true;
                            showCharInfo = raceCharacterProperties;
                            break;
                        }
                    }
                    //NULL EXCEPTION HANDLER, STRING EXCEPTION HANDLER
                    //if (....
                    //Maybe an exception of invalid character choice. ex 11

                    //***reselect character?***
                } //leaving while loop

                //user exit condition, if loop

                Console.WriteLine($"You are a {showCharInfo.CharacterName}.\n" +
                                  $"You have {showCharInfo.Lives}.");


            }







            //Console.ReadLine();
        }
    }
}
