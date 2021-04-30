using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Date
    {
        private int _date { set; get; }
        private int _month { set; get; }
        private int _year { set; get; }

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
