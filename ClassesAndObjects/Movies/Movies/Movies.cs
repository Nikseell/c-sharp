using System;

namespace Movies
{
    class Movies
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movies(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movies(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public static Movies[] GetPG(Movies[] mov)
        {
            Movies[] pgMov = new Movies[mov.Length];

            int index = 0;
            for (int i = 0; i < mov.Length; i++)
            {
                if (mov[i]._rating.Equals("PG"))
                {
                    pgMov[index] = mov[i];
                    index++;
                }
            }
            return pgMov;
        }

        public string PrintOut()
        {
            return $"{_title}, {_studio}, {_rating}";
        }
    }
}
