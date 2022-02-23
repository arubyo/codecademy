using System;

namespace truefalse
{
    class MainClass
    {
        public static void Main(string[] args)
        {

          

            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
                string entry = Console.ReadLine();
                


            string[] questions = new string[] { "50 Cent and Charlie Chaplin were alive at the same time.", "Trees existed before sharks.", "Michigan is larger than Great Britain.", "Cumulus clouds weigh anywhere from 15 to 30 pounds.", "There are 14 bones in a human foot." };

                bool[] answers = new bool[] { true, false, true, false, false };

                bool[] responses = new bool[questions.Length];


                if (questions.Length != answers.Length)
                {
                    Console.WriteLine("oiya, there is an error check your questions and answers to ensure they are the same legth");
                }

                int askingIndex = 0;

                foreach (string question in questions)
                {

                    Console.WriteLine(question);
                    Console.WriteLine("\n True or False?");
                    string userInput = Console.ReadLine();
                    bool isBool;
                    bool inputBool;



                    isBool = Boolean.TryParse(userInput, out inputBool);
                    while (isBool == false)
                    {
                        Console.WriteLine("Please respond with 'true' or 'false'");
                        string input = Console.ReadLine();
                        isBool = Boolean.TryParse(input, out inputBool);
                    };


                    responses[askingIndex] = inputBool;

                    askingIndex++;


                }

                int scoringIndex = 0;
                int score = 0;

                foreach (bool answer in answers)
                {

                    bool response = responses[scoringIndex];

                    Console.WriteLine($"Input: {response} | Answer: {answer}");

                    if (response == answer)
                    {
                        score++;
                    }
                    scoringIndex++;

                }

                Console.WriteLine($"You got {score} ot of {answers.Length} correct!");
            }

        }

    }




