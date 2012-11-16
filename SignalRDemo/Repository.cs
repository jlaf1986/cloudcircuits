using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo
{
    public static class Repository
    {

       

        public static List<String> GetSuscriptionsBySuscriber(String ProfileKey)
        {
            
            //Dictionary<String, String> suscriptions = new Dictionary<string, string>();
            List<String> suscriptions = new List<string>();

            switch (ProfileKey)
            {
                case "user1":
                    suscriptions.Add("group1");
                    break;
                case "user2":
                    suscriptions.Add("group1");
                    suscriptions.Add("group2");
                    break;
                case "user3":
                    suscriptions.Add("group1");
                    suscriptions.Add("group2");
                    suscriptions.Add("group3");
                    break;
            }

            return suscriptions;

        }


        public static List<String> GetSuscriptionsByBroadcaster(String ProfileKey)
        {

            //Dictionary<String, String> suscriptions = new Dictionary<string, string>();
            List<String> suscriptions = new List<string>();

            switch (ProfileKey)
            {
                case "group1":
                    suscriptions.Add("user1");
                    suscriptions.Add("user2");
                    suscriptions.Add("user3");
                    break;
                case "group2":
                    suscriptions.Add("user2");
                    suscriptions.Add("user3");
                   
                    break;
                case "group3":
                    suscriptions.Add("user3");
 
                    break;
            }

            return suscriptions;

        }

    }
}