﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMS.Models
{
    public class Application
    {
            public int id { get; set; }
            public int oppID { get; set; }
            public int volsNeeded { get; set; }
            public Opportunity opportunity { get; set; }
            public string oppName { get; set; }
            public string oppDate { get; set; }
            public string oppTime { get; set; }
            public string oppLocation { get; set; }
            public ApplicationUser volunteer { get; set; }
            public string volunteerName { get; set; }
            public bool status { get; set; }
            public bool isVirtual { get; set; }
            public string AboutYou { get; set; }
            public string InstagramLink { get; set; }
            public string FacebookLink { get; set; }
            public string TwitterLink { get; set; }
            public string OtherWebsite { get; set; }
            public string School { get; set; }
    }
}
