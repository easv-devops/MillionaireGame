using System;
using System.Collections.Generic;

namespace MillionaireGame
{
    class Program
    {
        static void Main(string[] args)
        {
         
            List<Question> competitionQuestions = Questions.GetCompetitionQuestions();
            List<Question> helpQuestions = Questions.GetHelpQuestions();
            GameEngine gameEngine = new GameEngine(competitionQuestions, helpQuestions);

           
            gameEngine.StartGame();
        }
    }
}
