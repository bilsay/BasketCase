using System;
using BasketCase.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasketCase
{
    public class TestBase
    {
        [TestInitialize]
        public void Init()
        {
            Given();
            //this.When();
        }

        public virtual void Given() { }

        public virtual void When(Action whenFunction)
        {
            whenFunction();
        }
    }

    public abstract class BasketBase : TestBase
    {
        protected Basket Basket;

        public override void Given()
        {
            Basket = new Basket ();
        }
    }

    //public abstract class SpecificationContext
    //{
    //    [TestInitialize]
    //    public void Init()
    //    {
    //        this.Given();
    //        this.When();
    //    }

    //    public virtual void Given() { }
    //    public virtual void When() { }
    //}

    //public class Calculator
    //{
    //    public int Result { get; private set; }
    //    public void Add(int p, int p_2)
    //    {
    //        this.Result = p + p_2;
    //    }
    //}
}
