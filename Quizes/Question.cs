using AppWithAISupport.Menus;
using System;
using System.Collections.Generic;

namespace AppWithAISupport.Quizes
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public List<string> ListOfAnswers { get; set; } = new List<string>();
        public int CorrectAnswerIndex { get; set; }

        public Question (string questionText, List<string> listOfAnswers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            ListOfAnswers = listOfAnswers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        /// <summary>
        /// Displays the Question as a menu and checks the users answer
        /// </summary>
        /// <returns>Returns a true if answer was correct/false if incorrect</returns>
        public bool RunQuestion()
        {
            Menu questions = new Menu(ListOfAnswers);
            int selectedIndex = questions.Run(QuestionText);

            return selectedIndex == CorrectAnswerIndex;
        }
    }
}
