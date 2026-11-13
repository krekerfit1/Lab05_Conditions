// Console.Write("ВВедите кол-во посещений (из 19):");
// int attendance = int.Parse(Console.ReadLine());
// Console.Write("ВВедите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttendance = attendance >= 14;
// bool goodGrades = practiceGpa >= 3.0;
// if (goodAttendance && goodGrades) {
//     Console.WriteLine("+ Допуск к экзамену разрешон");
// }
// else if (!goodAttendance && goodGrades) {
//     Console.WriteLine("- недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades) {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы");    
// }
// else {
//     Console.WriteLine("- проблемы и с посещаемостью и оценками. - казнить нельзя помиловать.");

// }

// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "сщвершеннолетний":
// "несовершеннолетний";
// Console.WriteLine($"{ageGroup}");
// Console.WriteLine("\nВведите температуру за окном (C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}");
// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "четное" : "нечетные";
// Console.WriteLine($"Число {n} - {parity}.");


// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");

// Console.Write("\nВведите температуру за окном (°C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");


// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "чётное" : "нечётное";
// Console.WriteLine($"Число {n} – {parity}.");


// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");

// string choice = Console.ReadLine();

// switch (choice) {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-244, каб. 102, 08:30");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИРСПО - 20, РМП - 35,");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("До свидания!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//         break;
// }




// Console.Write("\nВведите номер месяца (1-12): ");
// int monthNumber = int.Parse(Console.ReadLine());

// switch (monthNumber)
// {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("Зима");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Весна");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("Лето");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("Осень");
//         break;
//     default:
//         Console.WriteLine("Такого месяца не существует.");
//         break;
// }


// угадайка 

// Random random = new Random();
// int secret = random.Next(1, 101);

// int attempts = 0;
// bool guessed = false;

// Console.WriteLine("Угадай число (1-100)");
// Console.WriteLine("Я загадал число. Попробуй угадать!");

// while (!guessed)
// {
//     Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
//     string input = Console.ReadLine();

//     if (!int.TryParse(input, out int guess))
//     {
//         Console.WriteLine("!!! Введи целое число, а не текст!");
//         continue;
//     }

//     if (guess < 1 || guess > 100)
//     {
//         Console.WriteLine("!!! Число должно быть от 1 до 100!");
//         continue;
//     }

//     attempts++;

//     if (guess < secret)
//     {
//         int diff = secret - guess;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↑ Больше! {hint}\n");
//     }
//     else if (guess > secret)
//     {
//         int diff = guess - secret;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↓ Меньше! {hint}\n");
//     }
//     else
//     {
//         guessed = true;
//     }
// }

// string result = attempts <= 7
//     ? $"Отличный результат! Всего {attempts} попыток."
//     : $"Число найдено за {attempts} попыток. Можно лучше!";

// Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
// Console.WriteLine($"{result}");

// static string GetHint(int difference)
// {
//     switch (difference)
//     {
//         case <= 3:
//             return "🔥 Горячо!";
//         case <= 10:
//             return "🌡️ Тепло.";
//         case <= 25:
//             return "🌀 Прохладно.";
//         default:
//             return "❄️ Холодно!";
//     }
// }

//Задание 1

// Console.WriteLine("Введите пароль: ");
// string password = Console.ReadLine();

// Console.WriteLine("Подтвердите пароль: ");
// string confirmPassword = Console.ReadLine();
    
// if (password == confirmPassword)
// {
//     Console.WriteLine("Пароль принят");
// }
// else
// {
//     Console.WriteLine("Пароль не принят");
// }

//Задание 2

// Console.WriteLine("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());

// if (age >= 18)
// {
//     Console.WriteLine("Доступ разрешён");
// }
// else
// {
//     Console.WriteLine("Доступ запрещён");
// }


//задание 3

// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());

// Console.Write("Введите операцию (+, -, *, /): ");
// string operation = Console.ReadLine();

// switch (operation)
// {
//     case "+":
//         Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//         break;
//     case "-":
//         Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
//         break;
//     case "*":
//         Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
//         break;
//     case "/":
//         if (num2 != 0) 
//             Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
//         else
//             Console.WriteLine("НА НОЛЬ ДЕЛИТЬ НЕЛЬЗЯ");
//         break;
//     default:
//         Console.WriteLine("Неизвестная операция");
//         break;
// }

//задание 4

// Console.WriteLine("Введите три целых числа (каждое на новой строке):");
// int sum = 0;

// for (int i = 0; i < 3; i++)
// {
//     int currentNumber = int.Parse(Console.ReadLine());
//     if (currentNumber > 0)
//     {
//         sum += currentNumber;
//     }
// }

// Console.WriteLine($"Сумма положительных чисел: {sum}");

Console.WriteLine("Вы — отважный искатель приключений, отправившийся в Темный Лабиринт!");
Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути:");
Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
Console.WriteLine("Путь B: Пойти по тёмному коридору.");
Console.Write("Выберите путь (A или B): ");
string path = Console.ReadLine();

switch (path) {
    case "A":
    case "a":
        Console.WriteLine("\nВы вошли в комнату с огромным драконом.");
        Console.WriteLine("Дракон говорит: Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.");
        Console.Write("Ваш ответ: ");
        string answer = Console.ReadLine();

        if (answer == "рыба" || answer == "Рыба") {
            Console.WriteLine("Правильно! Дракон открывает дверь в следующую комнату.");
        }
        else {
            Console.WriteLine("Неправильно! Дракон вас съел!");
        }
        break;

    case "B":
    case "b":
    
        Console.WriteLine("\nВас ждёт тёмная комната с двумя дверями:");
        Console.WriteLine("Дверь 1");
        Console.WriteLine("Дверь 2");
        Console.Write("Выберите дверь (1 или 2): ");
        string door = Console.ReadLine();

        if (door == "1") {
            Console.WriteLine("Поздравляем! Вы нашли сокровища Dungeon Master'а!");
        }
        else if (door == "2") {
            Console.WriteLine("О нет! Вы попали в ловушку с ядовитыми шипами!");
        }
        else {
            Console.WriteLine("Такой двери здесь нет.");
        }
        break;

    default:
        Console.WriteLine("Ошибка: вы выбрали несуществующий путь.");
        break;
}