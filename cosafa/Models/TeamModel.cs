using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cosafa.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Represents the Global unique identifier
        /// </summary>
        public Guid id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Team Name
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Team Members
        /// </summary>

        public List<ApplicationUser> TeamMembers { get; set; } = new List<ApplicationUser>();
    }
}