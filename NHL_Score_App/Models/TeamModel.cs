using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHL_Score_App.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        public string Abbreviation { get; set; }
        public string Logo
        {
            get
            {
                return Enum.GetName(typeof(TeamEnum), Id);
            }
        }
    }
}
