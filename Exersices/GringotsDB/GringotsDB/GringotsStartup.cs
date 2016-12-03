using System;
using System.Data.Entity.Validation;
using GringotsDB.Models;

namespace GringotsDB
{
    class GringotsStartup
    {
        static void Main()
        {
            try
            {
                GringotsContext context = new GringotsContext();
                WizzardDeposit dumbledoreDeposit = new WizzardDeposit
                {
                    Wizzard = new Wizzard
                    {
                        Age = 120,
                        FirstName = "Cherniq",
                        LastName = "Riko"

                    },
                    Deposit = new Deposit
                    {
                        StartDate = new DateTime(2016, 10, 20),
                        ExpirationDate = new DateTime(2020, 10, 20),
                        Amount = 20000.24m,
                        Charge = 0.2m,
                        IsExpired = false
                    },
                    MagicWand = new MagicWand
                    {
                        MagicWandCreator = "AlalaBala",
                        MagicWandSize = 15
                    }
                };

                //WizzardDeposit deposit = new WizzardDeposit
                //{
                //    Age = 150,
                //    FirstName = "Peter",
                //    LastName = "Griphin",
                //    DepositAmount = 100,
                //    DepositCharge = 2.3m,
                //    DepositExpirationDate = new DateTime(1992, 02, 10),
                //    DepositGroup = "Orks",
                //    DepositInterest = 34.3m,
                //    DepositStartDate = new DateTime(1989, 10, 29),
                //    IsExpired = true,
                //    MagicWandCreator = "Peter Petrelli",
                //    MagicWandSize = 20
                //};

                context.WizzardDeposits.Add(dumbledoreDeposit);
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {

                foreach (DbEntityValidationResult dbEntityValidationResult in ex.EntityValidationErrors)
                {
                    foreach (DbValidationError dbValidationError in dbEntityValidationResult.ValidationErrors)
                    {
                        Console.WriteLine(dbValidationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
