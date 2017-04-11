using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Movies
{
    class Movie
    {
        private string _title;
        private string _category;

        public Movie (string title, string category)
        {
            _title = title;
            _category = category;
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    
    }
}