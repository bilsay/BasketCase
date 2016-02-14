using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasketCase.Tests
{
    public class TestBase
    {
        [TestInitialize]
        public void Init()
        {
            Given();
        }

        public virtual void Given() { }

        public virtual void When(Action when)
        {
            when ();
        }
    }
}
