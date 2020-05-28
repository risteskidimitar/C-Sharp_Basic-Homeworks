﻿namespace Market
{
    public class Product
    {
        // Field
        //private int _price;

        #region Get and Set methods
        // The very early beginnings... :)

        // Getter method - GET
        //public int GetPrice()
        //{
        //    return _price;
        //}

        // Setter method - SET
        //public void SetPrice(int value)
        //{
        //    _price = value;
        //}
        #endregion

        #region Property
        // Property
        //public int Price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}
        #endregion

        // Auto - implemented property => C# 

        // Read - Write Property
        //public int Price { get; set; }

        //public int Price { get; } // Read only property

        private float _price; // field
        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 100)
                   // Discount = 0.1f;

                _price = value - (value * Discount);
            }
        }

        public float Discount { get; private set; } = 0.1f;

        public Product()
        {
            Price = 100;
        }
    }
}