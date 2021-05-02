using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _inventory = new List<Video>();
        private List<string> _temp = new List<string>();

        public VideoStore()
        {
            
        }

        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
            _temp.Add(title);
        }
        
        public void Checkout(string title)
        {
            int name = _temp.IndexOf(title);
            if(_inventory[name].Available() == true)
            {
                Console.WriteLine($"You are checking out {title}");
            }
            else
            {
                Console.WriteLine("Movie is already getting check out!");
            }
        }

        public void ReturnVideo(string title)
        {
            int name = _temp.IndexOf(title);
            _inventory[name].BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            int name = _temp.IndexOf(title);
            _inventory[name].ReceivingRating(rating);
        }

        public void ListInventory()
        {
            for(int i = 0; i < _inventory.Count; i++)
            {
                Console.WriteLine(_inventory[i].ToString());
            }
        }
    }
}
