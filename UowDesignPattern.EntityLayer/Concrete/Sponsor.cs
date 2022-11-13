using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UowDesignPattern.EntityLayer.Concrete
{
    public class Sponsor
    {
        public int SponsorID { get; set; }
        public string SponsorName { get; set; }
        public List<Team> Teams { get; set; }
    }
}
