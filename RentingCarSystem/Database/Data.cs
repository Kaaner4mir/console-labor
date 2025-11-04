class Data
{
    public static List<Car> vehicles = new List<Car>()
    {
        new Car()
        {
            VehicleId=Random.Shared.Next(100000,999999),
            Brand="Toyota",
            Model="Corolla",
            Year=2023,
            Color="Gray",
            HP=125,
        },
        new Car()
        {
            VehicleId=Random.Shared.Next(100000,999999),
            Brand="BMW",
            Model="M5",
            Year=2023,
            Color="Blue",
            HP=200,
        },
        new Car()
        {
            VehicleId=Random.Shared.Next(100000,999999),
            Brand="Mercedes-Benz",
            Model="E-200",
            Year=2023,
            Color="Black",
            HP=185,
        },
        new Car()
        {
            VehicleId=Random.Shared.Next(100000,999999),
            Brand="Ford",
            Model="Mustang",
            Year=2015,
            Color="Yellow",
            HP=240,
        },
        new Car()
        {
            VehicleId=Random.Shared.Next(100000,999999),
            Brand="Seat",
            Model="Leon",
            Year=2018,
            Color="White",
            HP=115,
        },
        new Car()
        {
            VehicleId=Random.Shared.Next(100000,999999),
            Brand="Hyundai",
            Model="Elentra",
            Year=2020,
            Color="Red",
            HP=140,
        }
    };
}