using System;

namespace Task_5;

enum DayType
{
    Weekday,
    Weekend
}

record Book(string title, string author, double price);