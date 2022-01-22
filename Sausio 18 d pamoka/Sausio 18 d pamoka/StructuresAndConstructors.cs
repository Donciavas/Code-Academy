using System;
using System.Collections.Generic;
using System.Linq;

namespace Sausio_18_d_pamoka

{
    public struct Problem1Struct
    {

        // Sukurti struktūrą mokynis. Laukai: List<int> trimestras1, <int> trimestras2,
        // <int> trimestras 3. Metodai: public int PirmoTrimestroVidurkis(),
        // public int AntroTrimestroVidurkis(), public int trečioTrimestroVidurkis(),
        // public int MetinisPažimys() + unit testai;
        public List<double> Trim1;
        public List<double> Trim2;
        public List<double> Trim3;

        public Problem1Struct(List<double> trim1, List<double> trim2, List<double> trim3)
        {
            Trim1 = trim1;
            Trim2 = trim2;
            Trim3 = trim3;
        }

        public double TrimAvg(List<double> sum)
        {
            double x = 0;
            foreach (var item in sum)
            {
                x += item;
            }

            return Convert.ToInt32(x / sum.Count());
            
        }

        public double YearAvg(List<double> trim1, List<double> trim2, List<double> trim3)
        {
            double y = (TrimAvg(trim1) + TrimAvg(trim2) + TrimAvg(trim3)) / 3;
            y = Convert.ToInt32(y);
            return y;
        }

        public void PrintValues()
        {
            Console.WriteLine($"Trimester 1 average is: {TrimAvg(Trim1)}");
            Console.WriteLine($"Trimester 2 average is: {TrimAvg(Trim2)}");
            Console.WriteLine($"Trimester 3 average is: {TrimAvg(Trim3)}\r\n");
            Console.WriteLine($"       Year average is: {YearAvg(Trim1, Trim2, Trim3)}\r\n");
        }


    }

    public struct Problem2Struct
    {
        // Sukurti struktūrą Sąskaita.Laukai: SaskNr ir Viso.Sukurti struktūrą
        // Buhalterija.Laukai List<saskaita>.Pridėti metodus bendrai visų sąskaitų
        // sumai suskaičiuoti. Ekrane parodyti viso sąskaitų xxx, Viso Suma: yyy

        public string AccountNumber;
        public float AccountBalance;

        public Problem2Struct(string accountNumber, float accountBalance)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
        }
    }

    public struct Finances
    {
        public List<Problem2Struct> FinanceList;

        public Finances(List<Problem2Struct> financeList)
        {
            FinanceList = financeList;
        }

        public void AddToFinanceList(Problem2Struct row)
        {
            FinanceList.Add(row);
        }

        public (float, int) CalculateValues()
        {
            float sum = 0;
            int counter = 0;
            foreach (var row in FinanceList)
            {
                sum += row.AccountBalance;
                counter++;
            }
            var T1 = (sum, counter);
            return T1;
        }

        public void PrintValues()
        {
            Console.WriteLine($"  Sąkaitų suma yra: {CalculateValues().Item1}");
            Console.WriteLine($"Sąkaitų kiekis yra: {CalculateValues().Item2}");
        }
    }
}