using System;
using System.Data.Common;

namespace EasyTracker.data;

public class Expense
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required double Amount { get; set; }
    public required bool Monthly { get; set; }
}
