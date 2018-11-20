using MegaCasting.Controllers;
using MegaCasting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Repositories
{
    public abstract class Repository
    {

        public static void doThing()
        {
            FileReader fr = new FileReader();
            DBConnection dbConnection = fr.LightSqlConnection;
        }

            protected String sqlConnectionString = "Server=localhost\\SQLEXPRESS;Database=TeamSpaceDB;Trusted_Connection=True;";
    }




}
