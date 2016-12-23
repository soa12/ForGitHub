using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UIRS.Models
{
    public class Obrashenie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Name1 { get; set; }
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }
        [Required]
        public string Texttreatment { get; set; }
        public string Busnumber { get; set; }
        public string Bustype  { get; set; }
        public string Busgosnumber { get; set; }
        public string Busstop { get; set; }
        public DateTime DateAndTime { get; set; }
        //public DateTime Time  { get; set; }
        public int Waiting  { get; set; }
        public string FIOdriver { get; set; }
        public string FIOconductor { get; set; }
        public string FIOdispetcher { get; set; }
        public bool Earlyend { get; set; }
        public bool LateBeginning { get; set; }
        public bool BigInterval { get; set; }
        public bool BreachShedule { get; set; }
        public bool StopTravel { get; set; }
        public bool ViolationLanding { get; set; }
        public bool OutputWithoutContract { get; set; }
        public bool ViolationOfTrafficPatterns { get; set; }
        public bool VioletionOfTrafficRules { get; set; }
        public bool ConflictWithConductor { get; set; }
        public bool WrongSurrendere { get; set; }
        public bool NotAnnouncedBusstop { get; set; }
        public bool SmokingInCabin { get; set; }
        public bool DiscussionOnPhone { get; set; }
        public bool LoudMusic { get; set; }
        public bool LackOfTickets { get; set; }
        public bool FaultyBus { get; set; }
        public bool SmellOfGus { get; set; }
        public bool PoorSanCondition { get; set; }
        public bool WorkBoards { get; set; }
        public bool WorkSite { get; set; }
        public bool WorkSmsService { get; set; }
        public bool WorkOnLinemap { get; set; }
        public bool WorkMobileApplication { get; set; }
        public bool PoorStateReversalArea { get; set; }
        public bool PoorStateBusstop { get; set; }
        public bool DisadvantageOfInfrastructures { get; set; }
        public bool ConflictWithDispather { get; set; }
        public bool ComplianceWithShedule { get; set; }
        public bool GoodQualityService { get; set; }
        public bool CourteousStaff { get; set; }
        public bool GoodTransportCondition { get; set; }
    }
}