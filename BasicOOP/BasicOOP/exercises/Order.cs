using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.exercises
{
    public class Order
    {
        //your code goes here

        public string Item { get; }
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value.Year == DateTime.Now.Year)
                {
                    _date = value;
                }
            }
        }

        public Order(string item, DateTime date)
        {
            this.Item = item;
            this.Date = date;

        }
    }
}
