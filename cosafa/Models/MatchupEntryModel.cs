using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cosafa.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents the Global unique identifier
        /// </summary>
        public Guid id { get; set; } = Guid.NewGuid();

        public TeamModel TeamCompeting { get; set; }
        public double score { get; set; }

        public MatchupModel ParentMatchup { get; set; }
    }
}