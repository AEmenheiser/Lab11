using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Movie
        {

        private string _title;
        private string _genre;
        private int _genreID;

        public string Title
        {
            set
            {
                _title = value;
            }
            get
            {
                return _title;
            }
        }

        public string Genre
        {
            set
            {
                _genre = value;
            }
            get
            {
                return _genre;
            }
        }
        public int GiD
        {
            set
            {
                _genreID = value;
            }
            get
            {
                return _genreID;
            }
        }

       






    }
}
