using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Lecture5Notes
{
    internal class Product
    {
        //Fields
        private int uId;
        private String title;
        private String director;
        private double rating;
        private decimal price;

        //Constructor

        public Product(String title, String director)
        {
            Random rand = new Random();
            this.uId = rand.Next(100000000, 1000000000);

            this.title = title;
            this.director = director;
            this.rating = 0.0;
            this.price = 0.0m;
        }

        //Default Constructor
        public Product(String title, String director, double rating, decimal price)
        {
            Random rand = new Random();
            this.uId = rand.Next(100000000, 1000000000);

            this.title = title;
            this.director = director;
            this.rating = rating;
            this.price = price;
        }

        //Properties

        //Getters

        public double getRating()
        {
            return this.rating;
        }

        //Setters

        public void setRating(double rating)
        {
            this.rating = rating;
        }

        //Unique getters/setters
        
        public int UId { get => this.uId; private set => this.uId = value; }
        
        public String Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = title;
            }
        }
        public String Director
        {
            get
            {
                return this.director;
            }
            set
            {
                this.director = director;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new Exception("Enter a value Greater than 0");
                }
            }
        }

        //Methods


    }
}

