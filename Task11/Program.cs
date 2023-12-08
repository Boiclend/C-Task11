// Создать класс, описывающий понятие работник, со свойствами:

// фамилия;
// стаж;
// часовая заработная плата;
// количество отработанных часов.
// C помощью метода реализовать ввод данных работника с клавиатуры. Рассчитать с помощью методов заработную плату, 
// за отработанное время, и премию, размер которой определяется в зависимости от стажа 
// (при стаже до 1 года 0%, до 3 лет 5%, до 5 лет 8%, свыше 5 лет 15%).
// С помощью метода печати, реализовать вывод информации о работнике на экран. Предусмотреть метод для записи в файл данных о работнике.

Console.WriteLine("Enter workers surname : ");
string sr = Console.ReadLine();
Console.WriteLine("Enter workers expirience : ");
double ex = double.Parse(Console.ReadLine());
Console.WriteLine("Enter workers hourly wag :");
int hg = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter how much {sr} has worked :");
int hw = int.Parse(Console.ReadLine());


Worker nom1 = new (sr,ex,hg,hw); // Cоздание обьекта класса
Console.WriteLine();
nom1.Print(); // вызов метода печати
nom1.RecordToFile(); // вызов метода записи

class Worker // Определение класса 
{
    // поля
    public string Surname;
    public double Expirience;
    public int HourlyWag;
    public int HoursWorked;
    public int Salary;
    public int Premy;

    public Worker(string sur, double exp, int hag, int how) // рассчёт зп и премии
    {
        Surname = sur;
        Expirience = exp;
        HourlyWag = hag;
        HoursWorked = how;
        Salary = hag * how;
        if(Expirience < 1) Premy = 0; // если стаж < года
        if(Expirience > 1 && Expirience < 3 ) Premy = Salary / 100 * 5; // если стаж > года но < 3
        if(Expirience > 3 && Expirience < 5 ) Premy = Salary / 100 * 8; // если стаж > 3 лет но < 5
        if(Expirience > 5) Premy = Salary / 100 * 15; // если стаж > 5 лет 
    }

    public void Print() // метод вывода
    {
        Console.WriteLine($"Surname : {Surname}");
        Console.WriteLine($"Expirience is : {Expirience}");
        Console.WriteLine($"Hourly wage is: {HourlyWag}");
        Console.WriteLine($"{Surname} has worked {HoursWorked}");
        Console.WriteLine($"Salary is : {Salary}");
        Console.WriteLine($"Premy is : {Premy}");
    }

    public void RecordToFile() { // метод записи в файл
        string Info = "Surname is " + Surname + "'\n'Expirience is " + Expirience + "'\n'HourlyWag is " 
                      + HourlyWag + "'\n'HoursWorked is " + HoursWorked 
                      + "'\n'Salary is " + Salary + "'\n'Premy is " + Premy;
        File.WriteAllText(@"C:\\Users\РомаЛиля\Desktop\C#Task11\test.txt",Info); // запись
    }
}

