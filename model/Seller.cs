using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruit.model
{
    class Seller
    {
        private string name;
        private Controller.BucketController bucket;
        public Seller(string name, Controller.BucketController bucket)
        {
            this.name = name;
            this.bucket = bucket;
        }
        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }
        public void addFruit(Fruit fruit)
        {
            this.bucket.addFruit(fruit);
        }
    }
}