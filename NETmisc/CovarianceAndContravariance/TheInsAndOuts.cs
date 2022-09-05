using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    public class TheInsAndOuts
    {
        public void Covariance()
        {
            ICovariant<Fruit> fruit = new Covariant<Fruit>();
            ICovariant<Apple> apple = new Covariant<Apple>();
            ICovariant<Book> book = new Covariant<Book>();

            Covariant(fruit);
            Covariant(apple); //apple is being upcasted to fruit, without the out keyword this will not compile
            // Covariant(book);  //this will not compile because book does not inherit from Fruit class
        }

        public void Contravariance()
        {
            IContravariant<Fruit> fruit = new Contravariant<Fruit>();
            IContravariant<Apple> apple = new Contravariant<Apple>();

            Contravariant(fruit); //fruit is being downcasted to apple, without the in keyword this will not compile
            Contravariant(apple);
        }

        private void Covariant(ICovariant<Fruit> fruit)
        {

        }

        private void Contravariant(IContravariant<Apple> apple)
        {

        }
    }
}
