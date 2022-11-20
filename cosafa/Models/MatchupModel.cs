using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cosafa.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the Global unique identifier
        /// </summary>
        public Guid id { get; set; } = Guid.NewGuid();

        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        public TeamModel Winner { get; set; }

        public int MatchupRound { get; set; }

    }
}