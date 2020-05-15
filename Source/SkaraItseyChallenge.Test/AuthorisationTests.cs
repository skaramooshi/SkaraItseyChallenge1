using Plisky.Diagnostics;
using Plisky.Test;
using System;
using Xunit;

namespace SkaraItseyChallenge.Test {
    public class AuthorisationTests {
        protected Bilge b = new Bilge();


        [Fact(DisplayName = nameof(KnownBadLogin_Rejected))]
        [Trait(Traits.Age, Traits.Fresh)]
        [Trait(Traits.Style, Traits.Unit)]
        public void KnownGoodLogin_Works() {
            b.Info.Flow();

            string userName = "itsey";
            bool loggedIn = false;

            // TODO : Implement Login Call here

            Assert.True(loggedIn, "Good UserName Must Login");
        }


        [Fact(DisplayName = nameof(KnownBadLogin_Rejected))]
        [Trait(Traits.Age, Traits.Fresh)]
        [Trait(Traits.Style, Traits.Unit)]
        public void KnownBadLogin_Rejected() {
            b.Info.Flow();
            string userName = "mrHaxxor";
            bool loggedIn = false;

            // TODO : Implement Login Call Here

            Assert.False(loggedIn, "Bad UserName Must Not Login");
        }



        [Fact(DisplayName = nameof(NullLogin_ThrowsException))]
        [Trait(Traits.Age, Traits.Fresh)]
        [Trait(Traits.Style, Traits.Unit)]
        public void NullLogin_ThrowsException() {
            b.Info.Flow();
            
            string userName = string.Empty;            

            Assert.Throws<ArgumentNullException>(() => {
                // TODO : Implement Login Call here
            });
        }


        [Fact(DisplayName = nameof(EmptyLogin_ThrowsException))]
        [Trait(Traits.Age, Traits.Fresh)]
        [Trait(Traits.Style, Traits.Unit)]
        public void EmptyLogin_ThrowsException() {
            b.Info.Flow();
            string userName = string.Empty;

            Assert.Throws<ArgumentOutOfRangeException>(() => {
                // TODO : Implement Login Call here
            });
        }
    }
}
