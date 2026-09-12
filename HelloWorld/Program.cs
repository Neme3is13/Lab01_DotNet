// int age = 19;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Алексей";

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);

// var city = "Волжский";
// var year = 2026;
// var pi = 3.14;
// var isActive = true;

// string myName = "Aleksei";
// int myAge = 19;
// string myGroup = "ISP-243";

// Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");

// Console.Write("Введите ваше имя: ");
// string name2 = Console.ReadLine();
// Console.WriteLine($"hello, {name2}!");

// Console.Write("введите ваш возраст: ");
// string input = Console.ReadLine();
// int age2 = int.Parse(input);
// Console.WriteLine($"через 10 лет вам будет {age + 10} лет.");

// int x = 10;
// int y = 3;

// Console.WriteLine(x + y);
// Console.WriteLine(x - y);
// Console.WriteLine(x * y);
// Console.WriteLine(x / y);
// Console.WriteLine(x % y);

string firstName = "Leha";
string lastName = "Kovalevskii";
string group = "ISP-243";
int birthYear = 2007;
double gpa = 4.5;
bool hasScholarship = true;

int currentYear = 2026;
int age = currentYear - birthYear;

Console.WriteLine("Студенчиское удостоверение");
Console.WriteLine($"Имя: {firstName} {lastName}");
Console.WriteLine($"group: {group}");
Console.WriteLine($"Vozrast: {age} let");
Console.WriteLine($"Sr ball: {gpa}");
Console.WriteLine($"stipendia: {hasScholarship}");

Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"отлично! {firstName} любит {subject}");

