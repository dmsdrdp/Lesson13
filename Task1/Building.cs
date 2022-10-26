using System;

namespace Task1
{
    internal class Building
    {
        string adress;
        double l;
        double b;
        double h;

        double L
        {
            get
            {
                return l;
            }
            set
            {
                if (value<3)
                {
                    l = 3;
                }
                else
                {
                    l = value;
                }
            }
        }
        double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value < 3)
                {
                    b = 3;
                }
                else
                {
                    b = value;
                }
            }
        }
        double H
        {
            get
            {
                return h;
            }
            set
            {
                if (value < 3)
                {
                    h = 3;
                }
                else
                {
                    h = value;
                }
            }
        }

        public Building(string adress, double l, double b, double h)
        {
            this.adress = adress;
            this.L = l;
            this.B = b;
            this.H = h;
        }
        public string Print()
        {
            return $"Адрес:{adress} \nДлина здания: {l} м \nШирина здания: {b} м \nВысота здания: {h} м";
        }
    }
}
