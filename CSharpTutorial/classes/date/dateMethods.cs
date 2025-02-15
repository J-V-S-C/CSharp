namespace LearningCSharp.Date
{

    public static class DateMethods
    {
        public static void WorkingWithDates()

        {
            var Date1 = new DateTime(2049, 02, 10, 19, 22, 23);
            /*
            var Date2 = DateTime.Parse("2041-04-10 19:22:33");
            var Date3 = DateTime.Now;
            var Date4 = DateTime.Today;
            var Date5 = DateTime.UtcNow;
            var Date6 = DateTime.MinValue;
            var Date7 = DateTime.MaxValue;
            */
            Console.WriteLine(Date1.ToString("dd/MM/yyyy HH:mm:ss"));
            /*
            Console.WriteLine(Date2);
            Console.WriteLine(Date3);
            Console.WriteLine(Date4);
            Console.WriteLine(Date5);
            Console.WriteLine(Date6);
            Console.WriteLine(Date7);
            */

            var DateOffSet1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
            Console.WriteLine(DateOffSet1.UtcDateTime);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateOffSet1.LocalDateTime);
            Console.WriteLine(DateOffSet1);

        }

        public static void SubtractingDates()
        {
            var Date1 = new DateTime(2049, 02, 10, 19, 22, 23);
            var Date2 = DateTime.Now;
            var Date3 = Date1 - Date2;
            Console.WriteLine($"Segundos restantes  --> {(int)Date3.TotalSeconds}");
            Console.WriteLine($"Minutos restantes  ---> {(int)Date3.TotalMinutes}");
            Console.WriteLine($"Horas restantes   ----> {(int)Date3.TotalHours}");
            Console.WriteLine($"Dias restantes   -----> {(int)Date3.TotalDays}");
            Console.WriteLine($"Meses restantes ------> {(int)Date3.TotalDays / 30}");
            Console.WriteLine($"Anos restantes -------> {(int)Date3.TotalDays / 365}");
        }

        public static void AddDates()
        {
            var Date1 = new DateTime(2049, 02, 10, 19, 22, 23);
            var Date2 = Date1.AddHours(2).ToString("dd/MM/yyyy HH:mm:ss");
            var Date3 = Date1.AddMinutes(2).ToString("dd/MM/yyyy HH:mm:ss");
            var Date4 = Date1.AddDays(2).ToString("dd/MM/yyyy HH:mm:ss");
            var Date5 = Date1.AddMonths(2).ToString("dd/MM/yyyy HH:mm:ss");
            var Date6 = Date1.AddYears(2).ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine(Date2);
            Console.WriteLine(Date3);
            Console.WriteLine(Date4);
            Console.WriteLine(Date5);
            Console.WriteLine(Date6);

        }

        public static void weekDay()
        {

            var Date1 = DateTime.Now;
            Console.WriteLine(Date1.Date);

            Console.WriteLine(Date1.DayOfYear);
            Console.WriteLine(Date1.DayOfWeek);
        }

        public static void dateOnly()
        {
            var Date1 = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(Date1);
            Console.WriteLine(Date1.Day);
            Console.WriteLine(Date1.Month);
            Console.WriteLine(Date1.Year);
        }
    }
}