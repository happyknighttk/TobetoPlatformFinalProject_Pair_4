﻿using Core.Entities;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Experience : Entity<Guid>
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Sector { get; set; }
        public string City { get; set; }
        public DateTime BusinessStartDate { get; set; }
        public DateTime BusinessQuittinghDate { get; set; }

        //public InputCheckbox ContinuingWork { get; set; }?
        public string BusinessDescription { get; set; }
    }
}
