using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Personnel
    {
        protected string gender = "male";
        protected string name = "Dane";
        protected string mos = "Infantryman";
        protected string rank = "PVT";

        public Personnel(){ }
        public Personnel(string gender, string name, string mos, string aRank)
        {
            this.gender = gender;
            this.name = name;
            this.mos = mos;
            Rank = aRank;
            this.rank = Rank;
        }
        public virtual void Duty()
        {
            Console.WriteLine($"A {gender} {mos}, {rank} {name} is qualifying on a weapon, ");
        }
        
        public string Rank
        {
            get { return rank; }
            set { if (value == "PVT" || value == "SPC" || value == "SGT")
                {
                    rank = value;
                }
                else
                {
                    rank = "soldier";
                }
                }
           
        }
    }
}
