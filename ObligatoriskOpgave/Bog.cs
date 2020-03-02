using System;

namespace ObligatoriskOpgave
{
    public class Bog
    {
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;
        public string Titel { get; set; }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if(value.Length < 13 || value.Length > 13) throw new ArgumentOutOfRangeException();
                {
                   _isbn13 = value;
                }
                
            }
        }

        public string Forfatter
        {
            get => _forfatter;
            set
            {
                if(value.Length < 2) throw new ArgumentOutOfRangeException();
                {
                  _forfatter = value;
                }
                
            }
        }

        public int Sidetal
        {
            get => _sidetal;
            set
            {
                if (value < 4 || value > 1000) throw new ArgumentOutOfRangeException();
                {
                    _sidetal = value;
                }
                
            }
        }
    }
}
