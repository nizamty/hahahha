
{
    Random random = new Random();
    bool playAgain;

    do
    {
        int secretNumber = random.Next(1, 101);
        int maxAttempts = 10;
        int attempts = 0;
        bool hasGuessed = false;

        Console.WriteLine($"Добро пожаловать в игру 'Угадай число'!У вас есть {maxAttempts} попыток, чтобы угадать число от 1 до 100.");

        while (attempts < maxAttempts && !hasGuessed)
        {
            Console.Write("Введите ваше предположение: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userGuess))
            {
                attempts++;

                if (userGuess == secretNumber)
                {
                    hasGuessed = true;
                    Console.WriteLine("Поздравляем! Вы угадали число!");
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        }

        if (!hasGuessed)
        {
            Console.WriteLine($"Вы проиграли! Загаданное число было {secretNumber}.");
        }

        Console.Write("Хотите сыграть еще раз? (да/нет): ");
        string response = Console.ReadLine().ToLower();
        playAgain = response == "да" || response == "yes";

    } while (playAgain);

    Console.WriteLine("Спасибо за игру! Нажмите Enter для выхода.");
    Console.ReadLine();
}