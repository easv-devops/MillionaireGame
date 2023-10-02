using System;
using System.Collections.Generic;

namespace MillionaireGame
{
    public class Question
    {
        public string Text { get; }
        public List<string> Choices { get; }
        public int CorrectChoiceIndex { get; }
        public int PrizeAmount { get; }

        public Question(string text, List<string> choices, int correctChoiceIndex, int prizeAmount)
        {
            Text = text;
            Choices = choices;
            CorrectChoiceIndex = correctChoiceIndex;
            PrizeAmount = prizeAmount;
        }
    }

    class Questions
    {
        static Random random = new Random();

       public static List<Question> GetCompetitionQuestions()
{
    return new List<Question>
    {
        new Question("Hvad er hovedstaden i Danmark?", 
            new List<string> { "Stockholm", "København", "Oslo", "Helsinki" }, 
            1, 
            500),
        new Question("Hvilken farve har en moden banan?",
            new List<string> { "Grøn", "Gul", "Blå", "Rød" },
            1,
            1000),
        new Question("Hvad er verdens største ocean?",
            new List<string> { "Atlanterhavet", "Det Indiske Ocean", "Det Sydlige Ocean", "Stillehavet" },
            3,
            2000),
        new Question("Hvilket dyr er verdens største landlevende pattedyr?",
            new List<string> { "Blåhval", "Elefant", "Giraf", "Flodhest" },
            0,
            4000),
        new Question("Hvem skrev 'Hamlet'?",
            new List<string> { "William Shakespeare", "Charles Dickens", "Leo Tolstoy", "Jane Austen" },
            0,
            8000),  // First point of no return
        new Question("Hvad er hovedingrediensen i sushi?",
            new List<string> { "Pasta", "Kød", "Brød", "Ris" },
            3,
            15000),
        new Question("Hvilken planet er den nærmeste til solen?",
            new List<string> { "Mars", "Jupiter", "Venus", "Saturn" },
            2,
            30000),
        new Question("Hvem malede 'Stjernenatten'?",
            new List<string> { "Pablo Picasso", "Vincent van Gogh", "Leonardo da Vinci", "Claude Monet" },
            1,
            60000),
        new Question("Hvad er det kemiske symbol for vand?",
            new List<string> { "H2", "O", "H2O", "CO2" },
            2,
            120000),  // Second point of no return
        new Question("Hvem var den første mand på månen?",
            new List<string> { "Neil Armstrong", "Buzz Aldrin", "Yuri Gagarin", "John Glenn" },
            0,
            250000),
        new Question("Hvilken dansk forfatter skrev 'Eventyr og Historier'?",
            new List<string> { "Søren Kierkegaard", "H.C. Andersen", "Karen Blixen", "Isak Dinesen" },
            1,
            500000),
        new Question("Hvem opfandt glødelampen?",
            new List<string> { "Isaac Newton", "Marie Curie", "Galileo Galilei", "Thomas Edison" },
            3,
            1000000)  // Grand prize
    };
}


        public static List<Question> GetHelpQuestions()
        {
            return new List<Question>
            {
                new Question("Hvad er 1 + 1?", new List<string> { "1", "2", "3", "4" }, random.Next(0, 4), 500),
                new Question("Hvilket dyr siger 'vuf'?", new List<string> { "Kat", "Hund", "Giraf", "Elefant" }, random.Next(0, 4), 1000),
            };
        }
    }
}