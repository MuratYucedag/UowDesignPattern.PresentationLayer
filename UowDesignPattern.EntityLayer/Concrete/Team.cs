using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UowDesignPattern.EntityLayer.Concrete
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public List<Sponsor> Sponsors { get; set; }
    }
}
/*
 galatasaray--> beko arçelik thy
beşiktaş--> arçelik avis ülker

 */