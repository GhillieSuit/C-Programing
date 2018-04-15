using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Dog
    {
        const int MaxLevel = 10;

        int level = 1;
        string name = "NoName";

        public int Level
        {
            get
            {
                return this.level;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public Dog(string n)
        {
            this.level = 1;
            if (!string.IsNullOrEmpty(n))
                this.name = n;
        }

        public bool AddLevel()
        {
            if (this.level < 10)
            {
                this.level++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
