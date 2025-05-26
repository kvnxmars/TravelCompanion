using System;

namespace TravelCompanionAPI.Models
{
    public class TravelPlan
    {
        public int Id { get; set; }
        public string? Destination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
    }

    //this is jus to test the github
}
