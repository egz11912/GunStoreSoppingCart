﻿using System;
using Gunstoreshoppingcart.Models;
using System.Collections.Generic;
using System.Linq;

namespace Gunstoreshoppingcart
{

    public class Program
    {
        static void Main()
        {
            List<User> myList = new List<User>();

            User myFirstUser = new User();
            myFirstUser.UserId = 1;
            myFirstUser.Email = ("e@found.com");
            myFirstUser.SuperUser = ("yes");

            myList.Add(myFirstUser);


            User mySecondUser = new User();
            mySecondUser.UserId = 1;
            mySecondUser.Email = ("g@found.com");
            mySecondUser.SuperUser = ("yes");

            myList.Add(mySecondUser);


            User myThirdUser = new User();
            myThirdUser.UserId = 2;
            myThirdUser.Email = ("y@found.com");
            myThirdUser.SuperUser = ("no");

            myList.Add(myThirdUser);

            User myFourthUser = new User();
            myFourthUser.UserId = 3;
            myFourthUser.Email = ("j@found.com");
            myFourthUser.SuperUser = ("no");

            myList.Add(myFourthUser);

            User myFifthUser = new User();
            myFifthUser.UserId = 45;
            myFifthUser.Email = ("z@found.com");
            myFifthUser.SuperUser = ("yes");

            myList.Add(myFifthUser);

            User mySixthUser = new User();
            mySixthUser.UserId = 10;
            mySixthUser.Email = ("r@found.com");
            mySixthUser.SuperUser = ("no");

            myList.Add(mySixthUser);

            User mySeventhUser = new User();
            mySeventhUser.UserId = 165;
            mySeventhUser.Email = ("a@found.com");
            mySeventhUser.SuperUser = ("yes");

            myList.Add(mySeventhUser);

            User myEighthUser = new User();
            myEighthUser.UserId = 109;
            myEighthUser.Email = ("n@found.com");
            myEighthUser.SuperUser = ("no");

            myList.Add(myEighthUser);

            User myNinethUser = new User();
            myNinethUser.UserId = 8;
            myNinethUser.Email = ("e@found.com");
            myNinethUser.SuperUser = ("yes");

            myList.Add(myNinethUser);


            User myTenthUser = new User();
            myTenthUser.UserId = 10;
            myTenthUser.Email = ("em@found.com");
            myTenthUser.SuperUser = ("yes");

            myList.Add(myTenthUser);

            List<User> result = myList.Where(user => user.UserId == 10).ToList();

            if (result.Count == 0)
            {
                throw new IdNotFoundException("No users with id of 10");
            }

            try
            {

            }

             catch (IdNotFoundException Exception)
            {
                Console.WriteLine(Exception.Message);
            }

            foreach (var user in result)
            {
                Console.WriteLine(user.UserId);
                Console.WriteLine(user.Email);
            } 

        }

    }


     
}

public class IdNotFoundException : Exception
{
    public IdNotFoundException(string errorMessage) : base(errorMessage)
    {

    }

}

