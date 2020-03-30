# Лабораторна робота 14
 # Варіант 1
 ## Завдання 1
 Створити клас Prism, який представляє правильну призму і містить методи для знаходження площі поверхні та об’єму. На основі цього класу
 створити класи-нащадки Prism3 та Prism4, які представляють правильну трикутну та чотирикутну призми. З клавіатури вводиться дані для 
 створення правильної трикутної та чотирикутної призми. На їх основі поступово створити   правильних призм (трикутних та
 чотирикутних),об’єм кожної з яких на 5 більше попередньої. Для трикутних призм знайти сумарний об’єм, а для чотирикутних – суму площ
 поверхні. 
```cs
    Prism.cs
   
    public abstract class Prism
    {
        private protected double data;
        public double Data
        {
            get { return data; }
            set
            {
                if (value < 0)
                    throw new Exception("Cannot be negative");
                data = value;
            }
        }
        private protected double data2;
        public double Data2
        {
            get { return data2; }
            set
            {
                if (value < 0)
                    throw new Exception("Cannot be negative");
                data2 = value;
            }
        }
        public Prism(double data, double data2)
        {
            Data = data;
            Data2 = data2;
        }

        public abstract double Area();

        public abstract double Volume();




    }
    
    Prism3.cs
    
    class Prism3 : Prism
    {
        public Prism3(double a, double h) : base(a, h) { }

        public override double Area()
        {
            double Sb = 3 * Data * Data2;
            double So = Data * Data * Math.Pow(3, 1.0 / 2) / 4;
            double S = Sb + 2 * So;
            return S;
        }

        public override double Volume()
        {
            double So = Math.Pow(Data, 2) * Math.Pow(3, 1.0 / 2) / 4;
            double V = So * Data2;
            return V;
        }

        public override string ToString()
        {
            return $"Prism3: Sides = {Data}, {Data2}";
        }

    }
    
    Prism4.cs
    
    class Prism4 : Prism
    {
        public Prism4(double a, double h) : base(a, h) { }

        public override double Area()
        {
            double Sb = 4 * Data * Data2;
            double So = Data * Data;
            double S = Sb + 2 * So;
            return S;
        }

        public override double Volume()
        {
            return Data * Data * Data2;
        }

        public override string ToString()
        {
            return $"Prism4: Sides = {Data}, {Data2}";
        }


    }
    
    Program.cs
    
    static void Main(string[] args)
        {
            Prism p1;

            Prism3 p3 = new Prism3(6, 8);
            p1 = p3;
            double prmtr1 = p1.Volume();
            Console.WriteLine(prmtr1);
            double square1 = p1.Area();
            Console.WriteLine(square1);
            Prism4 p4 = new Prism4(12, 8);

            p1 = p4;
            double prmtr2 = p1.Volume();
            Console.WriteLine(prmtr2);
            double square2 = p1.Area();
            Console.WriteLine(square2);


            try
            {
                Console.Write("count of figures  = ");
                int m = Convert.ToInt32(Console.ReadLine());

                Prism[] objects = new Prism[m];
                Prism[] objects2 = new Prism[m];
                Random rnd = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < m; i++)
                {
                    objects[i] = new Prism3(rnd.Next(1, 10), rnd.Next(1, 10));
                    objects2[i] = new Prism4(rnd.Next(1, 10), rnd.Next(1, 10));
                }
                for (int i = 0; i < objects.Length; i++)
                {
                    Console.WriteLine(objects[i]);
                }
                double sumvol = 0;
                for (int i = 0; i < m; i++)
                {
                    sumvol += objects[i].Volume();
                }
                double sum = 0;
                for (int i = 0; i < m; i++)
                {
                    sum += objects2[i].Area();
                }
                Console.WriteLine($"sum of volumes = {sumvol}");
                Console.WriteLine($"sum of areas = {sum}");
            }
            catch
            {
                Console.WriteLine("Cannot be negative");
            }


        }
   ``` 
