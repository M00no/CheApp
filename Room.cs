namespace CheApp
{
    internal class Room
    {
        public string Name { get; set; }
        public string Index { get; set; }
        public string Type { get; set; }
        public string Building { get; set; }
        public int Volume { get; set; }
        public int Capacity { get; set; }
        public int Price{ get; set; }
        public int Expense { get; set; }

        public Room(string name, string index, string building, string type, int volume, int capacity, int price, int expense)
        {
            Name = name;
            Index = index;
            Building = building;
            Type = type;
            Volume = volume;
            Capacity = capacity;
            Price = price;
            Expense = expense;
        }

        //private float GetExpensesPerHour()
        //{
        //    string expensePerHourString;

        //    var yaml = File.ReadAllText("config.yaml");

        //    var deserializer = new DeserializerBuilder().Build();
        //    var res = deserializer.Deserialize<dynamic>(yaml);

        //    if (Capacity == null)
        //    {
        //        expensePerHourString = res["expenses"][Index][Type]["expense"];
        //    }
        //    else
        //    {
        //        expensePerHourString = res["expenses"][Index][Type]["capacity"][Capacity.ToString()]["expense"];
        //    }

        //    return float.Parse(expensePerHourString);
        //}

        //private float GetRentPricePerHour()
        //{
        //    var yaml = File.ReadAllText("config.yaml");

        //    var deserializer = new DeserializerBuilder().Build();
        //    var res = deserializer.Deserialize<dynamic>(yaml);

        //    string rentPriceString = res["rentPrice"][Index][Type]["price"];

        //    return float.Parse(rentPriceString);
        //}

        //private float GetDiscount()
        //{
        //    var yaml = File.ReadAllText("config.yaml");

        //    var deserializer = new DeserializerBuilder().Build();
        //    var res = deserializer.Deserialize<dynamic>(yaml);

        //    string discountString = res["discount"];

        //    return float.Parse(discountString);
        //}

        public string CalculateUsedOxygen(int totalPeople, int durationInHour) // Calculates how much oxygen is used and is over
        {
            if (totalPeople <= Capacity)
            {
                float totalOxygen = Volume * 0.21f * 1000;
                float oxygenLastsInHour = totalOxygen / (totalPeople * 30);

                if (oxygenLastsInHour >= durationInHour)
                {
                    float oxygenUsed = durationInHour * (totalPeople * 30);
                    float oxygenOver = totalOxygen - oxygenUsed;

                    return $"{oxygenUsed}L of oxygen will be used and {oxygenOver}L will be over in room {Index}";
                }
                else
                {
                    return $"There is not enough oxygen in room {Index}";
                }
            }
            return $"There are too many people for room {Index}";
        }

        //public float CalculateExpenses(DateTime begin, DateTime end)
        //{
        //    var durationInHours = (end - begin).TotalHours;
        //    float totalExpenses = 0;
        //    int morningHourCount = 0;

        //    for (int i = 0; i < durationInHours; i++)
        //    {
        //        DateTime currentDateTime = begin.AddHours(i);
        //        float expenses = GetExpensesPerHour();

        //        if (currentDateTime.Hour is >= 8 and <= 11)
        //        {
        //            expenses += 5 - morningHourCount;
        //            morningHourCount++;
        //        }
        //        if (currentDateTime.Hour == 0) morningHourCount = 0;

        //        totalExpenses += expenses;
        //    }

        //    return totalExpenses;
        //}
    }
}
