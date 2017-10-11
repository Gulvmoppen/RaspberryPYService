using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RaspberryPYService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RaspberryService1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RaspberryService1.svc or RaspberryService1.svc.cs at the Solution Explorer and start debugging.
    public class RaspberryService1 : IRaspberryService1
    {
        private const string ConnectionString =
            "Server=tcp:raspberryserver.database.windows.net,1433;Initial Catalog=RaspberryDB;Persist Security " +
            "Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=" +
            "True;TrustServerCertificate=False;Connection Timeout=30;";

        public int Analog(int anal)
        {
            const string insertAnalog = "insert into Anal (anal) value (@anal)";
            using (SqlConnection databaseConnection = new SqlConnection(ConnectionString))
            {
                databaseConnection.Open();
                using (SqlCommand insCommand = new SqlCommand(insertAnalog, databaseConnection))
                {
                    insCommand.Parameters.AddWithValue("@anal", anal);
                    int rowsAffected = insCommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }

        }

        public int Light(int lys)
        {
            const string insertLight = "insert into Lys (lys) values (@lys)";
            using (SqlConnection databaseConnection = new SqlConnection(ConnectionString))
            {
                databaseConnection.Open();
                using (SqlCommand insCommand = new SqlCommand(insertLight, databaseConnection))
                {
                    insCommand.Parameters.AddWithValue("@lys", lys);
                    int rowsAffected = insCommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }

        }

        public int Potentiometer(int potent)
        {
            const string insertPotent = "insert into Potent (potent) values (@potent)";
            using (SqlConnection databaseConnection = new SqlConnection(ConnectionString))
            {
                databaseConnection.Open();
                using (SqlCommand insCommand = new SqlCommand(insertPotent, databaseConnection))
                {
                    insCommand.Parameters.AddWithValue("@potent", potent);
                    int rowsAffected = insCommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        public int Tempreture(int temp)
        {
            const string insertTemp = "insert into Temp (temp) values (@temp)";
            using (SqlConnection databaseConnection = new SqlConnection(ConnectionString))
            {
                databaseConnection.Open();
                using (SqlCommand insCommand = new SqlCommand(insertTemp, databaseConnection))
                {
                    insCommand.Parameters.AddWithValue("@temp", temp);
                    int rowsAffected = insCommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

    }
}
