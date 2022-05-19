using System;

namespace vn_mode_csharp_dz09
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "exit";
            string userInputName;
            string userInputSecretWord = "";
            int countdown = 3;
            Console.Write("Привет, введи своё имя: ");
            userInputName = Console.ReadLine();
            while (secretWord != userInputSecretWord)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Ха-ха-ха! Ты попал в ловушку, {userInputName}!\n Чтобы выбраться из неё, тебе нужно ввести секретное слово!");
                userInputSecretWord = Console.ReadLine();
                countdown--;
                if (countdown == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Вот тебе подсказка, {userInputName}: СЕКРЕТНОЕ СЛОВО - ЭТО СЛОВО 'выход', только на английском");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Поздравляю, {userInputName}! Ты выбрался из ловушки!");
        }
    }
}
