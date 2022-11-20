using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cosafa.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the Global unique identifier
        /// </summary>
        public Guid id { get; set; } = Guid.NewGuid();

        public string TournamentName { get; set; }

        public decimal EntryFee { get; set; }

        /// <summary>
        /// Intialize Team Model
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}