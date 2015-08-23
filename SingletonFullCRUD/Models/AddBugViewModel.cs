using SingletonFullCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingletonFullCRUD.Models
{
    public class AddBugViewModel
    {
        public Bug Bug { get; set; }
        public List<Status> Statuses { get; set; }
    }
}