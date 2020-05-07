using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces
{
    public interface IEvent
    {
        int AccountID { get; set; }
        int CategoryID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime Date { get; set; }
        string Location { get; set; }
        int MaxCapacity { get; set; }
    }
}
