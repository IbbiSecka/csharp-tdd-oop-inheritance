﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper: Product
    {
        public string title;
        Boolean onLoan = false;

        public Newspaper(string title) {
            this.title = title;
        }

        public bool isOnLoan() {
            return onLoan;
        }

        public override string checkIn() {

            if (!this.isOnLoan())
            {
                return "newspapers are not available for loan";
            }

            this.onLoan = false;

            return "newspapers are not available for loan";
        }

        public override string checkOut() {
            if (this.isOnLoan())
            {
                return "item is currently on loan";
            }

            this.onLoan = true;

            return "newspapers are not available for loan";
        }
    }
}
