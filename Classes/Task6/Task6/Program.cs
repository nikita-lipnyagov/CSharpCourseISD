using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{

    class Converter
    {
        private double usd;
        private double eur;
        private double rub;

        public Converter (double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        double convertToUsd (double uah)
        {
            return uah / this.usd;
        }
        double convertToEur(double uah)
        {
            return uah / this.eur;
        }
        double convertToRub(double uah)
        {
            return uah / this.rub;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
