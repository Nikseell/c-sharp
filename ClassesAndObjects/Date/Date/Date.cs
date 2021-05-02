using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Date
    {
        private int _date;
        private int _month;
        private int _year;

        public Date(int date, int month, int year)
        {
            _date = date;
            _month = month;
            _year = year;
        }

        public string DisplayDate()
        {
            return $"{_month}/{_date}/{_year}";
        }
    }
}
