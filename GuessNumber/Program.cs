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




Console.Write("\nВведите номер месяца (1-12): ");
int monthNumber = int.Parse(Console.ReadLine());

switch (monthNumber)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Зима");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Весна");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Лето");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Осень");
        break;
    default:
        Console.WriteLine("Такого месяца не существует.");
        break;
}

