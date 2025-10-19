using System;
using System.Collections.Generic;

namespace AppWithAISupport.Quizes
{
    internal class Quiz
    {
        public List<Question> QuizQuestion { get; set; } = new List<Question>();
        public int Score { get; set; }
        public Quiz (string topic)
        {
            Score = 0; // Makes sure Score is 0 everytime the quiz starts
            
            // Hard coded questions, helped by AI. Last number in the question object indicates correct answer, the third argument in the Question constructor.
            
            switch (topic)
            {
                case "Geografi":
                    QuizQuestion.Add(new Question(
                        "Vad är huvudstaden i Schweiz?",
                        new List<string> { "Zürich", "Bern", "Genève", "Basel" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilken är Europas längsta flod?",
                        new List<string> { "Rhen", "Donau", "Volga", "Dnjepr" },
                        2
                    ));

                    QuizQuestion.Add(new Question(
                        "I vilket land ligger staden Marrakech?",
                        new List<string> { "Marocko", "Tunisien", "Algeriet", "Egypten" },
                        0
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilket hav ligger öster om Italien?",
                        new List<string> { "Tyrrenska havet", "Liguriska havet", "Adriatiska havet", "Egeiska havet" },
                        2
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilket land har flest invånare i världen (2025)?",
                        new List<string> { "USA", "Indien", "Kina", "Indonesien" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vad heter huvudstaden i Kanada?",
                        new List<string> { "Toronto", "Montréal", "Vancouver", "Ottawa" },
                        3
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilket land tillhör ön Bali?",
                        new List<string> { "Filippinerna", "Indonesien", "Malaysia", "Thailand" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilken flod rinner genom Egypten?",
                        new List<string> { "Nilen", "Eufrat", "Amazonas", "Mekong" },
                        0
                    ));

                    break;
                case "Historia":
                    QuizQuestion.Add(new Question(
                    "När startade andra världskriget?",
                    new List<string> { "1936", "1939", "1941", "1945" },
                    1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilken stad var centrum för det antika romerska riket?",
                        new List<string> { "Aten", "Rom", "Alexandria", "Kartago" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilket år började vikingatiden enligt historiker?",
                        new List<string> { "700", "793", "850", "900" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vad kallades den tid då riddare, borgar och feodalherrar dominerade Europa?",
                        new List<string> { "Antiken", "Medeltiden", "Renässansen", "Upplysningen" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vem var farao i Egypten som byggde de stora pyramiderna i Giza?",
                        new List<string> { "Tutankhamon", "Ramses II", "Cheops", "Cleopatra" },
                        2
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilken kung enade stora delar av Europa under 700-talet och kallades 'den store'?",
                        new List<string> { "Alexander den store", "Karl den store", "Gustav Vasa", "Julius Caesar" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilket land ledde upptäcktsresorna under 1400-talet med sjöfarare som Vasco da Gama?",
                        new List<string> { "Spanien", "Portugal", "Frankrike", "England" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilket år föll det västromerska riket?",
                        new List<string> { "395 e.Kr.", "410 e.Kr.", "476 e.Kr.", "500 e.Kr." },
                        2
                    ));
                    break;
                case "IT och Teknologi":
                    QuizQuestion.Add(new Question(
                    "Vad står förkortningen 'HTML' för?",
                    new List<string> { "HyperText Markup Language", "Hyper Transfer Main Link", "Home Tool Markup Language", "HighText Machine Language" },
                    0
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilket företag skapade operativsystemet Windows?",
                        new List<string> { "Apple", "IBM", "Microsoft", "Google" },
                        2
                    ));

                    QuizQuestion.Add(new Question(
                        "Vad används en GPU främst till?",
                        new List<string> { "Lagring av filer", "Bearbetning av grafik", "Hantering av ljud", "Ökning av internetfart" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilket år lanserades den första iPhonen?",
                        new List<string> { "2005", "2007", "2009", "2010" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vad betyder 'AI' inom teknik?",
                        new List<string> { "Automatiserad Information", "Artificiell Intelligens", "Avancerad Input", "Analytisk Integrering" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilken enhet mäter datorns processorhastighet?",
                        new List<string> { "RPM", "GHz", "MB", "FPS" },
                        1
                    ));

                    QuizQuestion.Add(new Question(
                        "Vilket företag skapade programmeringsspråket Java?",
                        new List<string> { "Sun Microsystems", "Microsoft", "Google", "IBM" },
                        0
                    ));

                    QuizQuestion.Add(new Question(
                        "Vad är syftet med en brandvägg (firewall)?",
                        new List<string> { "Skydda mot obehörig nätverkstrafik", "Öka datorns hastighet", "Lagra filer säkrare", "Förbättra grafikprestanda" },
                        0
                    ));
                    break;
            }
        }

        /// <summary>
        /// Starts the actual quiz of the program. Loops through equal to the amount of questions, if answer is correct, increase the score.
        /// </summary>
        public void StartQuiz()
        {
            Score = 0;
            bool quizBool;

            for(int i = 0; i < QuizQuestion.Count; i++)
            {
                quizBool = QuizQuestion[i].RunQuestion();
                if (quizBool == true)
                {
                    Score++;
                }
            }
            Console.WriteLine($"Du svarade rätt på {Score} av {QuizQuestion.Count} frågor.");
            Console.WriteLine("Klicka på valfri tangentknapp för att starta om programmet...");
            Console.ReadKey(true);
        }
    }
}
