class Data
{
    public static List<Car> cars = new List<Car>()
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

    public static List<Bus> buses = new List<Bus>()
    {
        new Bus()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Mercedez",
            Model="O302",
            Year=2015,
            Color="White",
            Capacity=65
        },
        new Bus()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="MAN",
            Model="solo-CNG",
            Year=2014,
            Color="Gray",
            Capacity=50
        },
        new Bus()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Temsa",
            Model="Avenue",
            Year=2020,
            Color="Black",
            Capacity=80
        },
        new Bus()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Iveco",
            Model="Crossway",
            Year=2024,
            Color="White",
            Capacity=90
        },
        new Bus()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="BMC",
            Model="PROCITY",
            Year=2015,
            Color="Yellow",
            Capacity=52
        }
    };

    public static List<Commercial> commercials = new List<Commercial>()
    {
        new Commercial()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Mercedez-Benz",
            Model="Sprinter",
            Year=2025,
            Color="Black",
            Area="School Service"
        },
        new Commercial()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Maxus",
            Model="V90",
            Year=2024,
            Color="Black",
            Area="Working Service"
        },
        new Commercial()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Fiat",
            Model="Ducato",
            Year=2023,
            Color="Red",
            Area="Merchant"
        },
        new Commercial()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Mercedez-Benz",
            Model="Sprinter",
            Year=2025,
            Color="Black",
            Area="School"
        },
        new Commercial()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Mercedez-Benz",
            Model="Vito",
            Year=2025,
            Color="Piano Black",
            Area="VIP"
        },
    };

    public static List<Motocycle> motocycles = new List<Motocycle>()
    {
        new Motocycle()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Ducati",
            Model="Panigale V4",
            Year=2024,
            Color="Red",
            CC=1000
        },
        new Motocycle()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Yamaha",
            Model="R1",
            Year=2025,
            Color="Blue",
            CC=1000
        },
        new Motocycle()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Aprilla",
            Model="RS 457",
            Year=2024,
            Color="Red",
            CC=450
        },
        new Motocycle()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Honda",
            Model="1000RR",
            Year=2022,
            Color="White",
            CC=1000
        },
        new Motocycle()
        {
            VehicleId= Random.Shared.Next(100000,999999),
            Brand="Yamaha",
            Model="XMAX",
            Year=2024,
            Color="Black",
            CC=600
        },
    };
}