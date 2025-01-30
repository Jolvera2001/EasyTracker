using System;
using System.Data.Common;

namespace EasyTracker.data;

public class Expense
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Amount { get; set; }
    public bool Monthly { get; set; }
}
