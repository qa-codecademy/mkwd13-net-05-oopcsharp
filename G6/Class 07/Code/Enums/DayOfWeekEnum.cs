namespace Enums
{
    public enum DayOfWeekEnum //we change the name of our enum and we usually add Enum in the end
    {
        //if we don't specify the value, the first enum will have value 0
        Monday = 1,
        Tuesday, //the next value will have the previous enum value + 1
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
