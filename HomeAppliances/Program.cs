namespace HomeAppliances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Appliance> applianceList = new List<Appliance>();

            WashingMachine wmachine1 = new WashingMachine(40);
            WashingMachine wmachine2 = new WashingMachine();

            Television tv1 = new Television(50, true);
            Television tv2 = new Television();

            applianceList.Add(wmachine1);
            applianceList.Add(wmachine2);
            applianceList.Add(tv1);
            applianceList.Add(tv2);

            float addPrice = 0;
            float wmachinesPrice = 0;
            float tvsPrice = 0;
            int items = 1;

            foreach (Appliance a in applianceList)
            {
                a.FinalPrice();
                Console.WriteLine($"Item # {items} is a {a.GetType()} that costs {a.BasePrice} usd");
                Console.WriteLine("");
                addPrice = addPrice + a.BasePrice;

                if (a.GetType() == typeof(WashingMachine))
                {
                    wmachinesPrice = wmachinesPrice + a.BasePrice;
                }
                else if (a.GetType() == typeof(Television))
                {
                    tvsPrice = tvsPrice + a.BasePrice;
                }
                items++;
            }
            Console.WriteLine($"Total cost of Washing Machines is {wmachinesPrice} usd");
            Console.WriteLine($"Total cost of Televisions is {tvsPrice} usd");
            Console.WriteLine($"Total cost of all items is {addPrice} usd");

            Console.ReadKey();
        }
    }
}