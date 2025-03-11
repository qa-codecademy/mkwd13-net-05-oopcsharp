//DateTime

DateTime emptyDateTime = new DateTime();
Console.WriteLine(emptyDateTime);

//create DateTime with current Date and Time(local date and time, from the server)
DateTime currentDateTime = DateTime.Now;
Console.WriteLine(currentDateTime);

DateTime universalDateTime = DateTime.UtcNow;
Console.WriteLine(universalDateTime);

DateTime specificDate = new DateTime(1999, 07, 28); //year month day
Console.WriteLine(specificDate);

DateTime specificDateTime = new DateTime(2024, 07, 28, 12, 34, 45); //year, month, day, hour, minute, second
Console.WriteLine(specificDateTime);

int day = currentDateTime.Day;
Console.WriteLine(day);

int month = currentDateTime.Month;
Console.WriteLine(month);

int year = currentDateTime.Year;
Console.WriteLine(year);

var dayOfWeek = currentDateTime.DayOfWeek;
Console.WriteLine(dayOfWeek);

DateTime firstDateTime = new DateTime(2000, 2, 3, 15, 55, 20);
DateTime secondDateTime = new DateTime(2025, 11, 3, 19, 28, 20);

var difference = secondDateTime - firstDateTime;
Console.WriteLine(difference);

int days = difference.Days;
int hours = difference.Hours;
int minutes = difference.Minutes;
Console.WriteLine(days);
Console.WriteLine(minutes);
Console.WriteLine(hours);

//get the date and time 5 days from now
DateTime fiveDaysAhead = currentDateTime.AddDays(5);
Console.WriteLine(fiveDaysAhead);

//get the date and time 5 days and 5 hours from now
DateTime fiveDaysAndFiveHoursAhead = currentDateTime.AddDays(5).AddHours(5);
Console.WriteLine(fiveDaysAndFiveHoursAhead);

//get the date and time 2 years and 3 months ago
DateTime threeMonthsAndTwoYearsAgo = currentDateTime.AddMonths(-3).AddYears(-2);
Console.WriteLine(threeMonthsAndTwoYearsAgo);

//Formatting datetime to string
string formattedDate = DateTime.Now.ToString("dd.MM.yyyy"); //11.03.2025
Console.WriteLine(formattedDate);

string anotherFormattedDate = DateTime.Now.ToString("dddd, dd MMMM yyyy");
Console.WriteLine(anotherFormattedDate);