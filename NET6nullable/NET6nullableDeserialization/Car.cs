namespace NET6nullableDeserialization
{
    public class Car
    {
        public string Name { get; set; }
        public int AmountOfDoors { get; set; }

        public Car(string name, int amountOfDoors)
        {
            Name = name;
            AmountOfDoors = amountOfDoors;
        }
    }
}
