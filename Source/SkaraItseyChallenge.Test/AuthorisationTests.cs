using Plisky.Diagnostics;
using Plisky.Test;
using System;
using Xunit;

namespace SkaraItseyChallenge.Test {
    public class AuthorisationTests {
        protected Bilge b = new Bilge();


        [Fact(DisplayName = nameof(TestMethod))]
        [Trait(Traits.Age, Traits.Fresh)]
        [Trait(Traits.Style, Traits.Unit)]
        public void TestMethod() {
            b.Info.Flow();


            Assert.True(false, "Not coded");
        }

    }
}
