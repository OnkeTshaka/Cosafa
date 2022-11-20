using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cosafa.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the Global unique identifier - generates a random combination of numbers and letters
        /// </summary>
        public Guid id { get; set; } = Guid.NewGuid();

        public int PlaceNumber { get; set; }

        public string PlaceName { get; set; }

        public decimal PrizeAmount { get; set; }

        public double PrizePercentage { get; set; }
    }
}