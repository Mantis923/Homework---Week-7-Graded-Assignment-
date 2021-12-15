using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7Week7
{
    class Counter
    {
        private int count;

        public Counter()
        {
            count = 1;
        }

        public void setCounterToZero()    //Sets counter to zero
        {
            count = 0;
        }
        public void addOneToCount() //increases count by 1
        {
            count += 1;//count ++
        }
        public void subtractOnceFromCounter()   // decreases count by 1
        {
            if (count != 0)        //avoiding negative value
                count -= 1;//count --
        }
        public void OutputCountToScreen()
        {
            Console.WriteLine(count);
        }
        public override string ToString()
        {
            return " " + count;
        }
        public Boolean equals(Counter other)
        {

            return other.count == this.count;

        }
    }
}