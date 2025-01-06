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
        public float Price{ get; set; }
        public float Expense { get; set; }
        public float Discount { get; set; }

        public Room(string name, string index, string type, string building, int volume, int capacity, float price, float expense, float discount)
        {
            Name = name;
            Index = index;
            Type = type;
            Building = building;
            Volume = volume;
            Capacity = capacity;
            Price = price;
            Expense = expense;
            Discount = discount;
        }

        public (float?, float?, string?) calculateOxygen(int totalPeople, int durationInHour) // Calculates how much oxygen is used and is over
        {
            if (totalPeople <= Capacity)
            {
                float totalOxygen = Volume * 0.21f * 1000;
                float oxygenLastsInHour = totalOxygen / (totalPeople * 30);

                if (oxygenLastsInHour >= durationInHour)
                {
                    float oxygenUsed = durationInHour * (totalPeople * 30);
                    float oxygenOver = totalOxygen - oxygenUsed;

                    return (oxygenUsed, oxygenOver, null);
                }
                else
                {
                    return (null, null, "NOT_ENOUGH_OXYGEN");
                }
            }
            return (null, null, "TOO_MANY_PEOPLE");
        }

        public float calculateExpenses(DateOnly beginDate, DateOnly endDate, TimeOnly beginTime, TimeOnly endTime)
        {
            int totalDays = endDate.DayNumber - beginDate.DayNumber + 1;
            int hoursPerDay = (endTime - beginTime).Hours;

            float rentExpense = hoursPerDay * Expense;
            float additionalExpense = calculateAdditionalExpenses(beginTime, endTime);


            return totalDays * (rentExpense + additionalExpense);
        }

        private float calculateAdditionalExpenses(TimeOnly beginTime, TimeOnly endTime)
        {
            float additionalExpense = 5;
            float totalAdditionalExpense = 0;

            int additionalEndTimeHour = endTime.Hour < 12 ? endTime.Hour : 12;
            for (int currentHour = beginTime.Hour; currentHour < additionalEndTimeHour; currentHour++)
            {
                totalAdditionalExpense += additionalExpense;
                additionalExpense--;
            }

            return totalAdditionalExpense;
        }

        public float calculatePrice(DateOnly beginDate, DateOnly endDate, TimeOnly beginTime, TimeOnly endTime)
        {
            int totalDays = endDate.DayNumber - beginDate.DayNumber + 1;
            int hoursPerDay = (endTime - beginTime).Hours;

            float rentPricePerDay = hoursPerDay * Price;
            //float discount = calculateDiscount(beginDate, endDate);

            return totalDays * rentPricePerDay;// - discount;
        }

        private float calculateDiscount(DateOnly beginDate, DateOnly endDate)
        {
            int totalFridays = 0;

            for(DateOnly currentDate = beginDate; currentDate <= endDate; currentDate.AddDays(1))
            {
                if(currentDate.DayOfWeek == DayOfWeek.Friday) totalFridays++;
            }

            float discount = Price * totalFridays * (1 - Discount/100);

            return discount;
        }
    }
}
