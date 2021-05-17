namespace AdApp
{
    public class TVAd: Advert
    {
        private int _time;
        private int _cost;
        private bool _isDouble;
        public TVAd(int fee, int time, int cost, bool isDouble) : base(fee)
        {
            _time = time;
            _cost = cost;
            _isDouble = isDouble;
        }
        
        public new int Cost() {
            var temp = _isDouble == true ? _cost * 2 : _cost;
            return base.Cost() + temp * _time;
        }

        public override string ToString() {
            return base.ToString();
        }
    }
}