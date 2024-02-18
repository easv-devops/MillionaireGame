using Xunit;
using System.Collections.Generic;

namespace MillionaireGame.Test1
{
    public class GameEngineTests
    {
        [Fact]
        public void GetNextQuestion_ShouldReturnNullIfNoMoreQuestionsAvailable()
        {
            // Arrange
            var competitionQuestions = new List<Question>
            {
                new Question("Question 1", new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" }, 0, 100),
                new Question("Question 2", new List<string> { "Choice A", "Choice B", "Choice C", "Choice D" }, 2, 200),
            };
            var helpQuestions = new List<Question>();
            var gameEngine = new GameEngine(competitionQuestions, helpQuestions);

            // Act
            var firstQuestion = gameEngine.GetNextQuestion();
            var secondQuestion = gameEngine.GetNextQuestion();
            var thirdQuestion = gameEngine.GetNextQuestion();
    
            // Assert
            Assert.NotNull(firstQuestion);
            Assert.NotNull(secondQuestion);
            Assert.NotNull(thirdQuestion);
            Assert.Null(gameEngine.GetNextQuestion()); 
        }
    }
}