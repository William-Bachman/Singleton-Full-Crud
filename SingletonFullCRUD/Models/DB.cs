using SingletonFullCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingletonFullCRUD.Models
{
    //NOT A STATIC CLASS
    public class DB
    {
        // Properties (as many as you want)
        public List<Bug> Bugs { get; set; }

        // Define Singleton
        private static DB _instance;

        //this is the only public static property
        public static DB Instance
        {
            get
            {
                return _instance ?? (_instance = CreateDB());
            }
        }

        //Same as writing if (_instance == null) { _instance = new DB() { ... } }
        private static DB CreateDB()
        {
            return new DB()
            {
                Bugs = new List<Bug>()
                {
                    new Bug() { BugId = 1, Message = "Fake Bug 1", Priority = Priority.Low, Status = Status.InProgress, UserNameSubmitted = "Jeremy"},
                    new Bug() { BugId = 2, Message = "Fake Bug 2", Priority = Priority.Medium, Status = Status.Fixed, UserNameSubmitted = "Jeremy"},
                    new Bug() { BugId = 3, Message = "Fake Bug 3", Priority = Priority.Submitted, Status = Status.CheckedOut, UserNameSubmitted = "Jeremy"},
                    new Bug() { BugId = 4, Message = "You wanna know how I got these scars? My father was... a drinker, and a fiend. And one night, he goes off crazier than usual. Mommy gets the kitchen knife to defend herself. He doesn't like that, not one bit. So, me watching he takes the knife to her, laughing while he does it. He turns to me and he says: Why so serious?. He comes at me with the knife Why so serious?. He sticks the blade in my mouth. Let's put a smile on that face. and... Why so serious?", Priority = Priority.Medium, Status = Status.InProgress, UserNameSubmitted = "Jeremy"}
                }
            };
        }

        //private empty constructor
        private DB()
        {
        }
    }
}