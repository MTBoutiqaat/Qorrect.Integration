﻿namespace Qorrect.Integration.Helper
{
    public class ConnectionString
    {
        private static string cName = "Server=.;Database=QBDemerdash;Trusted_Connection=True;Application Name=Qorrect;";
        public static string CName
        {
            get => cName;
        }
    }
}
