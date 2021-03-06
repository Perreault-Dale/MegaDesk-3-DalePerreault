﻿using System;
using System.IO;

namespace MegaDesk_3_DalePerreault
{
    class Deskquote
    {
        // class members
        private string custName { get; set; }
        private Desk custDesk { get; set; }
        private int prodDays { get; set; }
        private DateTime orderDate { get; set; }
        private int price { get; set; }

        // constructor method
        public Deskquote(string name, int days, int wide, int deep, int draw, Surface surface)
        {
            custName = name;
            custDesk = new Desk(wide, deep, draw, surface);
            prodDays = days;
            orderDate = DateTime.Today;
            price = 200;
            calcPrice(custDesk, prodDays);
        }

        // add surface charge
        public int addSurface(Desk desk)
        {
            int cost = 0;
            switch (desk.surface)
            {
                case Surface.Laminate:
                    cost = 100;
                    break;
                case Surface.Oak:
                    cost = 200;
                    break;
                case Surface.Pine:
                    cost = 50;
                    break;
                case Surface.Rosewood:
                    cost = 300;
                    break;
                case Surface.Veneer:
                    cost = 125;
                    break;
            }
            return cost;
        }

        // add size surcharge
        public int addSurcharge(Desk desk)
        {
            int cost = desk.width * desk.depth - 1000;
            return cost;
        }

        // add cost for drawers
        public int addDrawers(Desk desk)
        {
            int cost = desk.drawers * 50;
            return cost;
        }

        // add upcharge for rush delivery
        public int addRush(Desk desk, int rush)
        {
            int cost = 0;
            switch (rush)
            {
                case 3:
                    cost = 70;
                    if (desk.width * desk.depth < 1000) { cost = cost - 10; }
                    else if (desk.width * desk.depth > 2000) { cost = cost + 10; }
                    break;
                case 5:
                    cost = 50;
                    if (desk.width * desk.depth < 1000) { cost = cost - 10; }
                    else if (desk.width * desk.depth > 2000) { cost = cost + 10; }
                    break;
                case 7:
                    cost = 35;
                    if (desk.width * desk.depth < 1000) { cost = cost - 5; }
                    else if (desk.width * desk.depth > 2000) { cost = cost + 5; }
                    break;
            }
            return cost;
        }

        public void calcPrice(Desk desk, int rush)
        {
            price = price + addDrawers(desk) + addRush(desk, rush) + addSurcharge(desk) + addSurface(desk);
        }

        public void writeQuote()
        {
            StreamWriter sw = new StreamWriter("quotes.txt");
            sw.WriteLine(this.ToString());
            sw.Close();
        }
    }
}
