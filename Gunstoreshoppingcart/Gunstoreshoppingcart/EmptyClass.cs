using System;
using Gunstoreshoppingcart.Models;
using System.Collections.Generic;

namespace Gunstoreshoppingcart
{
    public class Program
    {
        static void Main()
        {
            List<Users> myList = new List<Users>();

            Users myFirstUser = new Users();
            myFirstUser.UserId = 1;
            myFirstUser.Email = ("e@found.com");
            myFirstUser.SuperUser = ("yes");

            myList.Add(myFirstUser);


            Users mySecondUser = new Users();
            mySecondUser.UserId = 1;
            mySecondUser.Email = ("g@found.com");
            mySecondUser.SuperUser = ("yes");

            myList.Add(mySecondUser);


            Users myThirdUser = new Users();
            myThirdUser.UserId = 2;
            myThirdUser.Email = ("y@found.com");
            myThirdUser.SuperUser = ("no");

            myList.Add(myThirdUser);

            Users myFourthUser = new Users();
            myFourthUser.UserId = 3;
            myFourthUser.Email = ("j@found.com");
            myFourthUser.SuperUser = ("no");

            myList.Add(myFourthUser);

            Users myFifthUser = new Users();
            myFifthUser.UserId = 45;
            myFifthUser.Email = ("z@found.com");
            myFifthUser.SuperUser = ("yes");

            myList.Add(myFifthUser);

            Users mySixthUser = new Users();
            mySixthUser.UserId = 7;
            mySixthUser.Email = ("r@found.com");
            mySixthUser.SuperUser = ("no");

            myList.Add(mySixthUser);

            Users mySeventhUser = new Users();
            mySeventhUser.UserId = 165;
            mySeventhUser.Email = ("a@found.com");
            mySeventhUser.SuperUser = ("yes");

            myList.Add(mySeventhUser);

            Users myEighthUser = new Users();
            myEighthUser.UserId = 109;
            myEighthUser.Email = ("n@found.com");
            myEighthUser.SuperUser = ("no");

            myList.Add(myEighthUser);

            Users myNinethUser = new Users();
            myNinethUser.UserId = 8;
            myNinethUser.Email = ("e@found.com");
            myNinethUser.SuperUser = ("yes");

            myList.Add(myNinethUser);


            Users myTenthUser = new Users();
            myTenthUser.UserId = 10;
            myTenthUser.Email = ("em@found.com");
            myTenthUser.SuperUser = ("yes");

            myList.Add(myTenthUser);









        }
    }
}
