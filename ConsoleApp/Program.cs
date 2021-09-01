using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PassCar pc = new PassCar()
            {
                Character = "Авто",
                Type = "Легковой",
                Model = "Lexus",
                GV = 2015,
                KolMest = 4
            };
            pc.InfoPassCar();
            Console.WriteLine();

            CargoCar cc = new CargoCar()
            {
                Character = "Авто",
                Type = "Грузовой",
                Model = "Porter",
                GV = 2012,
                GruzP = 500
            };
            cc.InfoCargoCar();
            Console.WriteLine();

            PassPlain pp = new PassPlain()
            {
                Character = "Самолёт",
                Type = "Пассажирский",
                Model = "Boeing",
                GV = 2012,
                KolMest = 500
            };
            pp.InfoPassPlain();
            Console.WriteLine();

            CargoPlain cp = new CargoPlain()
            {
                Character = "Самолёт",
                Type = "Грузовой",
                Model = "Airbus",
                GV = 2010,
                GruzP = 10000
            };
            cp.InfoCargoPlain();
            Console.WriteLine();

            PassTrain pt = new PassTrain()
            {
                Character = "Поезд",
                Type = "Пассажирский",
                Model = "Poezd",
                GV = 2012,
                KolMest = 500
            };
            pt.InfoPassTrain();
            Console.WriteLine();

            CargoTrain ct = new CargoTrain()
            {
                Character = "Поезд",
                Type = "Грузовой",
                Model = "Poezd",
                GV = 2010,
                GruzP = 10000
            };
            ct.InfoCargoTrain();
        }
    }

    class Transport
    {
        public string Character;

        public Transport() { }
        public Transport (string character)
        {
            Character = character;
        }

    }
    class Auto : Transport
    {
        public string Type;

        public Auto() { }
        public Auto (string type) :base()
        {
            Type = type;
        }

    }

    class Airplane : Transport
    {
        public string Type;

        public Airplane() { }
        public Airplane (string type) :base()
        {
            Type = type;
        }

    }

    class Train : Transport
    {
        public string Type;
        
        public Train() { }
        public Train (string type) : base()
        {
            Type = type;
        }
    }

    class PassCar : Auto
    {
        public string Model;
        public int GV;
        public int KolMest;

        public PassCar() { }
        public PassCar(string model, int gv, int kolmest) : base()
        {
            Model = model;
            GV = gv;
            KolMest = kolmest;
            
        }

        public void InfoPassCar()
        {
            Console.WriteLine($"Вид транспорта: {Character}\nТип: {Type}\nВместимость пассажиров: {KolMest}\nМодел: {Model}\nГод выпуска: {GV}");
        }


    }

    class CargoCar : Auto
    {
        public string Model;
        public int GV;
        public int GruzP;

        public CargoCar() { }
        public CargoCar(string model, int gv, int gruzp) : base()
        {
            Model = model;
            GV = gv;
            GruzP = gruzp;

        }

        public void InfoCargoCar()
        {
            Console.WriteLine($"Вид транспорта: {Character}\nТип: {Type}\nГрузоподъемность: {GruzP}\nМодел: {Model}\nГод выпуска: {GV}");
        }

    }

    class CargoPlain : Airplane
    {
        public string Model;
        public int GV;
        public int GruzP;

        public CargoPlain() { }
        public CargoPlain(string model, int gv, int gruzp) :base() 
        {
            Model = model;
            GV = gv;
            GruzP = gruzp;
        }

        public void InfoCargoPlain()
        {
            Console.WriteLine($"Вид транспорта: {Character}\nТип: {Type}\nГрузоподъемность: {GruzP}\nМодел: {Model}\nГод выпуска: {GV}");
        }

    }

    class PassPlain : Airplane
    {
        public string Model;
        public int GV;
        public int KolMest;

        public PassPlain() { }
        public PassPlain(string model, int gv, int kolmest) : base()
        {
            Model = model;
            GV = gv;
            KolMest = kolmest;

        }

        public void InfoPassPlain()
        {
            Console.WriteLine($"Вид транспорта: {Character}\nТип: {Type}\nВместимость пассажиров: {KolMest}\nМодел: {Model}\nГод выпуска: {GV}");
        }

    }
    class CargoTrain : Train
    {
        public string Model;
        public int GV;
        public int GruzP;

        public CargoTrain() { }
        public CargoTrain(string model, int gv, int gruzp) : base()
        {
            Model = model;
            GV = gv;
            GruzP = gruzp;
        }

        public void InfoCargoTrain()
        {
            Console.WriteLine($"Вид транспорта: {Character}\nТип: {Type}\nГрузоподъемность: {GruzP}\nМодел: {Model}\nГод выпуска: {GV}");
        }

    }

    class PassTrain : Train
    {
        public string Model;
        public int GV;
        public int KolMest;

        public PassTrain() { }
        public PassTrain(string model, int gv, int kolmest) : base()
        {
            Model = model;
            GV = gv;
            KolMest = kolmest;

        }

        public void InfoPassTrain()
        {
            Console.WriteLine($"Вид транспорта: {Character}\nТип: {Type}\nВместимость пассажиров: {KolMest}\nМодел: {Model}\nГод выпуска: {GV}");
        }

    }

}
