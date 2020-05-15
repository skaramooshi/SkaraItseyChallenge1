using Plisky.Diagnostics;
using Plisky.Test;
using SkaraItseyChallenge1;
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
            
            Authorisation a = new Authorisation();
            loggedIn = a.IsValid(userName);

            Assert.True(loggedIn, "Good UserName Must Login");
        }


        [Fact(DisplayName = nameof(KnownBadLogin_Rejected))]
        [Trait(Traits.Age, Traits.Fresh)]
        [Trait(Traits.Style, Traits.Unit)]
        public void KnownBadLogin_Rejected() {
            b.Info.Flow();
            string userName = "mrHaxxor";
            bool loggedIn = false;

            Authorisation a = new Authorisation();
            loggedIn = a.IsValid(userName);

            Assert.False(loggedIn, "Bad UserName Must Not Login");
        }



        [Fact(DisplayName = nameof(NullLogin_ThrowsException))]
        [Trait(Traits.Age, Traits.Fresh)]
        [Trait(Traits.Style, Traits.Unit)]
        public void NullLogin_ThrowsException() {
            b.Info.Flow();
            
            string userName = string.Empty;
            Authorisation a = new Authorisation();

            Assert.Throws<ArgumentNullException>(() => {
                // TODO : Implement Login Call here                
                a.IsValid(userName);
            });
        }


        [Fact(DisplayName = nameof(EmptyLogin_ThrowsException))]
        [Trait(Traits.Age, Traits.Fresh)]
        [Trait(Traits.Style, Traits.Unit)]
        public void EmptyLogin_ThrowsException() {
            b.Info.Flow();
            string userName = string.Empty;
            Authorisation a = new Authorisation();

            Assert.Throws<ArgumentOutOfRangeException>(() => {
                a.IsValid(userName);
            });
        }
    }
}
