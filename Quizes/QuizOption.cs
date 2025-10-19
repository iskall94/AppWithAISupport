using AppWithAISupport.Menus;
using System;
using System.Collections.Generic;

namespace AppWithAISupport.Quizes
{
    internal class QuizOption
    {
        public List<string> TopicOptions { get; set; } = new List<string>();

        // Add all the list of topic alternatives here
        public QuizOption()
        {
            TopicOptions.Add("Geografi");
            TopicOptions.Add("Historia");
            TopicOptions.Add("IT och Teknologi");
        }

        /// <summary>
        /// Method that makes a new menu with choices, returns the string, based on the index selected
        /// </summary>
        /// <returns>Returns the topic of choice</returns>
        public string SelectTopic()
        {
            Menu topicMenu = new Menu(TopicOptions);
            int selectedIndex = topicMenu.Run("Välj ett nytt ämne:");
            string chosenTopic = TopicOptions[selectedIndex];

            return chosenTopic;
        }
    }
}
