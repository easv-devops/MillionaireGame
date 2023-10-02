using System;
using System.Collections.Generic;
using System.Linq;

namespace MillionaireGame
{
    public class GameEngine
    {
        private List<Question> questions;
        private List<Question> helpQuestions;
        private int currentQuestionIndex = 0;
        private int currentBalance = 0;
        private int earnedBalance = 0;
        private Player player;

        public GameEngine(List<Question> competitionQuestions, List<Question> helpQuestions)
        {
            this.questions = competitionQuestions;
            this.helpQuestions = helpQuestions;
            this.player = new Player();
        }

        public void StartGame()
        {


            while (currentQuestionIndex < questions.Count)

            {
                DisplayBalance();

                Question currentQuestion = GetNextQuestion();
                DisplayQuestion(currentQuestion);

                string choice = GetUserChoice();
                if (choice == "h")
                {
                    if (player.LifelinesRemaining > 0)
                    {
                        UseHelp();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No lifelines remaining!");
                        continue;
                    }
                }
                else if (choice == "withdraw")
                {
                    Withdraw();
                    break;
                }
                else
                {
                    bool isCorrect = CheckAnswer(currentQuestion, int.Parse(choice) - 1);
                    if (!isCorrect)
                    {
                        Console.WriteLine($"Wrong answer! You've won: {GetPointOfNoReturnBalance()}");
                        break;
                    }
                }
            }

            EndGame();
        }

        private int GetPointOfNoReturnBalance()
        {
            if (currentQuestionIndex > 9) 
            {
                return 120000; 
            }
            else if (currentQuestionIndex > 5) 
            {
                return 8000; 
            }
            return 0; 
        }


        private void DisplayBalance()
        {
            Console.WriteLine($"Current Balance: {currentBalance}");
            Console.WriteLine($"Earned Balance: {earnedBalance}");
        }

        private Question GetNextQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                return questions[currentQuestionIndex++];
            }

            return null;
        }

        private void DisplayQuestion(Question question)
        {
            if (question != null)
            {
                Console.WriteLine($"Question: {question.Text}");
                for (int i = 0; i < question.Choices.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Choices[i]}");
                }
            }
        }

        private string GetUserChoice()
        {
            Console.Write("Your choice (1-4, H for Help, Withdraw to stop): ");
            return Console.ReadLine().Trim().ToLower();
        }

        private void UseHelp()
        {
           
            if (helpQuestions.Count > 0)
            {
                questions.Insert(currentQuestionIndex, helpQuestions[0]);
                helpQuestions.RemoveAt(0);
            }
        }

        private bool CheckAnswer(Question currentQuestion, int choice)
        {
            if (currentQuestion != null)
            {
                return choice == currentQuestion.CorrectChoiceIndex;
            }

            return false;
        }

        private void Withdraw()
        {
            Console.WriteLine($"You've withdrawn from the game. Your final balance is: {earnedBalance}");
        }

        private void EndGame()
        {
            Console.WriteLine($"Game Over! Your final balance: {currentBalance}");
        }
    }
}
