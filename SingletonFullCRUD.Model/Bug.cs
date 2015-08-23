using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFullCRUD.Model
{
    public class Bug
    {
        public int BugId { get; set; }
        public string Message { get; set; }
        public string UserNameSubmitted { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
    }

    public enum Status
    {
        NotLookedAt, //0
        CheckedOut, //1
        InProgress, //2
        Fixed //3
    }

    public enum Priority
    {
        Submitted, //0
        Low, //1
        Medium, //2
        High //3
    }
}