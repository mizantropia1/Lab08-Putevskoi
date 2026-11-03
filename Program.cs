Console.WriteLine();
Console.WriteLine("Шаг 1. Исходный код.");
int lessonNumber = 1;
int totalLessons = 5;

while (lessonNumber <= totalLessons) {
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber++;
}

Console.WriteLine("Пары закончились");



Console.WriteLine();
Console.WriteLine("Шаг 1. Обратным порядком.");
int lessonNumber1 = 5;

while (lessonNumber1 >= 1) {
    Console.WriteLine($"Пара {lessonNumber1}");
    lessonNumber1--;
}

Console.WriteLine("Пары закончились");



Console.WriteLine();
Console.WriteLine("Шаг 2. Исходный код.");
Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ввод завершён");



Console.WriteLine();
Console.WriteLine("Шаг 2. Подсчёт количества введённых оценок.");
Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade1 = int.Parse(Console.ReadLine());
int count1 = 0;

while (grade1 != -1)
{
    Console.WriteLine($"Оценка принята: {grade1}");
    count1 = count1 + 1;
    grade1 = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ввод завершён");
Console.WriteLine($"Всего оценок: {count1}");



Console.WriteLine();
Console.WriteLine("Шаг 3. Исходный код.");
int sum2 = 0;
int count2 = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade2 = int.Parse(Console.ReadLine());

while (grade2 != -1) {
    sum2 += grade2;
    count2++;
    grade2 = int.Parse(Console.ReadLine());
}

if (count2 > 0) {
    Console.WriteLine($"Средний балл: {(double)sum2 / count2}");
} else {
    Console.WriteLine("Оценок не было введено");
}



Console.WriteLine();
Console.WriteLine("Шаг 3. Наибольшая оценка.");
int sum3 = 0;
int count3 = 0;
int max3 = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade3 = int.Parse(Console.ReadLine());

while (grade3 != -1) {
    sum3 += grade3;
    count3++;

    if (grade3 > max3) {
        max3 = grade3;
    }

    grade3 = int.Parse(Console.ReadLine());
}

if (count3 > 0) {
    Console.WriteLine($"Средний балл: {(double)sum3 / count3}");
    Console.WriteLine($"Наибольшая оценка: {max3}");
} else {
    Console.WriteLine("Оценок не было введено");
}



Console.WriteLine();
Console.WriteLine("Шаг 4. Исходный код.");
string correctPassword = "qwerty123";

while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        break;
    }

    Console.WriteLine("Неверный пароль, попробуйте снова");
}



Console.WriteLine();
Console.WriteLine("Шаг 4. Подсчёт количества неудачных попыток.");
string correctPassword1 = "qwerty123";
int failedAttempts1 = 0;

while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password1 = Console.ReadLine();

    if (password1 == correctPassword1) {
        Console.WriteLine("Доступ разрешён");
        break;
    }

    failedAttempts1 = failedAttempts1 + 1;
    Console.WriteLine("Неверный пароль, попробуйте снова");
}

Console.WriteLine($"Неудачных попыток: {failedAttempts1}");



Console.WriteLine();
Console.WriteLine("Шаг 5. Исходный код.");
string answer;

do {
    Console.Write("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.Write("Добавить ещё одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");

Console.WriteLine("Дневник сохранён");



Console.WriteLine();
Console.WriteLine("Задача А.");
int n = 5;
int i = 1;

while (i <= 10) {
    Console.WriteLine($"{n} x {i} = {n * i}");
    i++;
}



Console.WriteLine();
Console.WriteLine("Задача Б.");
int count = 0;

Console.WriteLine("Вводите имена, для завершения введите «конец»:");
string name = Console.ReadLine();

while (name != "конец") {
    count = count + 1;
    name = Console.ReadLine();
}

Console.WriteLine($"Введено имён: {count}");



Console.WriteLine();
Console.WriteLine("Индивидуальный вариант.");
Console.Write("Введите свою фамилию: "); 
string surname = Console.ReadLine()!.Trim(); 
 
if (string.IsNullOrEmpty(surname)) { 
    Console.WriteLine("Фамилия не введена. Завершение работы."); 
    return; 
} 
 
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
 
var assigned = Enumerable.Range(1, 10) 
    .OrderBy(_ => rnd.Next()) 
    .Take(2) 
    .OrderBy(x => x) 
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");



Console.WriteLine();
Console.WriteLine("Вариант 5. Подбор кода домофона.");
string correctCode = "2382";

while (true) {
    Console.Write("Введите код домофона: ");
    string code = Console.ReadLine();

    if (code == correctCode)
    {
        Console.WriteLine("Дверь открыта");
        break;
    }

    Console.WriteLine("Неверный код, попробуйте снова");
}



Console.WriteLine();
Console.WriteLine("Вариант 9. Сумма чётных чисел.");
int n5 = 20;
int sum5 = 0;
int i5 = 1;

while (i5 <= n5)
{
    if (i5 % 2 == 0)
    {
        sum5 = sum5 + i5;
    }

    i5++;
}

Console.WriteLine($"Сумма чётных чисел от 1 до {n5}: {sum5}");



Console.WriteLine();
Console.WriteLine("Дополнительное задание. Банкомат.");
string correctPin = "9911";
int attempts = 0;
bool success = false;

while (attempts < 3 && success == false) {
    Console.Write("Введите PIN-код: ");
    string pin = Console.ReadLine();

    if (pin == correctPin)
    {
        success = true;
    }
    else
    {
        attempts = attempts + 1;
        Console.WriteLine("Неверный PIN");
    }
}

if (success == false) {
    Console.WriteLine("Карта заблокирована");
    return;
}

double total = 0;

Console.WriteLine("Введите суммы снятия, для завершения введите 0:");
double amount = double.Parse(Console.ReadLine());

while (amount != 0) {
    total = total + amount;
    amount = double.Parse(Console.ReadLine());
}

Console.WriteLine($"Итоговая снятая сумма: {total}");
