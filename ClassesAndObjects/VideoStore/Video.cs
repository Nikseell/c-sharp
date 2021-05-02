using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _flag;
        private List<double> _rating = new List<double>();

        public Video(string title)
        {
            _title = title;
        }

        public void BeingCheckedOut()
        {
            _flag = false;
        }

        public void BeingReturned()
        {
            _flag = true;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {
            double sum = 0;
            for(int i = 0; i < _rating.Count; i++)
            {
                sum += _rating[i];
            }
            return sum / _rating.Count;
        }

        public bool Available()
        {
            return _flag;
        }

        public override string ToString()
        {
            return $"{_title} {AverageRating()} {_flag}";
        }
    }
}
