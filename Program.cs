using AppWithAISupport.Menus;
using AppWithAISupport.Quizes;
using System;

namespace AppWithAISupport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mainMenuOptions = new List<string>();
            mainMenuOptions.Add("Starta Quizet");
            mainMenuOptions.Add("Ändra Quizets Ämne");
            mainMenuOptions.Add("Avsluta");

            Menu mainMenu = new Menu(mainMenuOptions);

            // Default topic option
            string quizTopic = "Geografi";

            // Main "menu" where choice based on index is chosen.

            while(true)
            {
                int MenuChoice = mainMenu.Run($"--- Välkommen till Quiz Appen ---\nNuvarande ämne: {quizTopic}\nAnvänd piltangenterna: (Upp/Ner) för att navigera.");

                switch (MenuChoice)
                {
                    case 0:
                        Quiz currentQuiz = new Quiz(quizTopic);
                        currentQuiz.StartQuiz();
                        break;
                    case 1:
                        QuizOption topicSelection = new QuizOption();
                        string newTopic = topicSelection.SelectTopic();
                        quizTopic = newTopic;
                        break;
                    case 2:
                        Console.WriteLine("Avslutar programmet efter 3 sekunder...");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
