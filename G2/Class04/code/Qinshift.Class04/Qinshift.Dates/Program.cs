Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n================ Working With Dates ================\n\n");
Console.ResetColor();


#region Creating DateTime

Console.WriteLine("\n============= Creating DateTime =============\n");

// 1) Creating an empty DateTime
DateTime emptyDate = new DateTime();
Console.WriteLine(emptyDate);

// 2) Creating a custom date          
DateTime customDate = new DateTime(1994, 10, 23, 19, 20, 30);
//DateTime customDate = new DateTime(year: 1994, month: 10, day: 23);
Console.WriteLine(customDate);

// 3) Creating a DateTime with the current Date
DateTime currentDate = DateTime.Today;
Console.WriteLine(currentDate);

// 4) Creating a DateTime with the current Date and Time
DateTime currentDateTime = DateTime.Now;
Console.WriteLine(currentDateTime);
Console.WriteLine(DateTime.UtcNow);

#endregion


#region Parsing
Console.WriteLine("\n============= Parsing =============\n");
// => Converting from string to DateTime
// => Variations:
//string stringDate = "12.15.2012";
//string stringDate = "12/15/2012 11:14:34";
//string stringDate = "12/15/12";
//string stringDate = "dec.15.12";
string stringDate = "12-15-2024 12:34:24";
DateTime.TryParse(stringDate, out DateTime parsedDateTime);
Console.WriteLine(parsedDateTime);
#endregion


#region DateTime Properties
Console.WriteLine("\n============= DateTime Properties =============\n");

DateTime currentDateAndTime = DateTime.Now;
int month = currentDateAndTime.Month;
Console.WriteLine(month);

Console.WriteLine(currentDateAndTime.Day);

Console.WriteLine(currentDateAndTime.Year);

Console.WriteLine(currentDateAndTime.Ticks);
Console.WriteLine(currentDateAndTime.DayOfWeek);
Console.WriteLine(currentDateAndTime.DayOfYear);

#endregion


#region DateTime Methods
Console.WriteLine("\n============= DateTime Methods =============\n");

// 1) Adding or removing days to a DateTime date
DateTime addedDays = DateTime.Now.AddDays(2);
Console.WriteLine(addedDays);
Console.WriteLine(DateTime.Now.AddDays(-5));

// 2) Adding/Removing months to a DateTime date
DateTime addedMonths = currentDateAndTime.AddMonths(5);
Console.WriteLine(addedMonths);

// 3) Adding/Removing years to a DateTime date
DateTime addedYears = currentDateTime.AddYears(2);
Console.WriteLine(addedYears);

// 4) Adding/Removing hours to a DateTime date
DateTime addedHours = currentDateTime.AddHours(3);
Console.WriteLine(addedHours);
#endregion


#region Formatting Dates
Console.WriteLine("\n============= Formatting Dates =============\n");

string dateFormat1 = currentDateAndTime.ToString("dd/MM/yyyy");
Console.WriteLine(dateFormat1);
string dateFormat2 = currentDateAndTime.ToString("dd/MM/yyyy HH:mm:ss");
Console.WriteLine(dateFormat2);
string dateFormat3 = currentDateAndTime.ToString("dddd, dd MMMM yyyy");
Console.WriteLine(dateFormat3);
string dateFormat4 = string.Format("Today is {0:dd-MMMM-yyyy}", currentDateAndTime);
Console.WriteLine(dateFormat4);

#endregion


#region Bonus (not mandatory)
Console.WriteLine("\n============= BONUS =============\n");

// *** Comparing Dates ***
Console.WriteLine(DateTime.Now < DateTime.UtcNow); // False
DateTime dt1 = new DateTime(2025, 9, 24, 14, 30, 0);
DateTime dt2 = new DateTime(2025, 9, 24, 9, 15, 0);
Console.WriteLine(dt1 == dt2); // False
// Example: Comparing only the dates (ignoring the time)
Console.WriteLine(dt1.Date == dt2.Date); // True

// *** Calculate time distance between two dates ***
DateTime dateInstance1 = DateTime.UtcNow;
DateTime dateInstance2 = DateTime.UtcNow.AddDays(3).AddHours(5.5);
// TimeSpan => represents a time interval
TimeSpan timeDifference = dateInstance2 - dateInstance1;
//TimeSpan timeDifference2 = dateInstance2.Subtract(dateInstance1); // same thing as above just using built-in method
Console.WriteLine($"The time differene between {dateInstance1:MM/dd/yyyy HH:mm:ss} and {dateInstance2:MM/dd/yyyy HH:mm:ss} is exactly {timeDifference.Days} days, {timeDifference.Hours} hours and {timeDifference.Minutes} minutes.");

// *** Other useful methods ***
Console.WriteLine(DateTime.UtcNow.ToShortDateString()); // 3/7/2024
Console.WriteLine(DateTime.UtcNow.ToLongDateString()); // Thursday, March 7, 2024
Console.WriteLine(DateTime.UtcNow.ToShortTimeString()); // 11:30 AM
Console.WriteLine(DateTime.UtcNow.ToLongTimeString()); // 11:30:52 AM
Console.WriteLine(DateTime.UtcNow.ToFileTime()); // 133542846524008581 // used as unique timestamp for some scenarios (for example timestamp in some file name)

// *** DateOnly & TimeOnly ***
DateOnly dateOnly = new DateOnly(2025, 3, 8);
DateOnly currentDateOnly = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"Today's date: {currentDateOnly}");

TimeOnly timeOnly = new TimeOnly(14, 30, 0);
TimeOnly currentTimeOnly = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"Current time: {currentTimeOnly}");

#endregion