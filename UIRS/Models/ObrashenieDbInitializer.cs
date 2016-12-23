using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UIRS.Models
{
    public class ObrashenieDbInitializer : DropCreateDatabaseIfModelChanges<ObrashenieContext>
    {
        protected override void Seed(ObrashenieContext db)
        {
            var obrashenie1 = new Obrashenie
            {
                Id = 1,
                Lastname = "Иванов",
                Name1 = "Иван",
                Surname = "Иванович",
                Email = "ivanov@mail.ru",
                Phone = "89131064589",
                Texttreatment = "Текс обращения",
                Busnumber = "19",
                Bustype = "bustype",
                Busgosnumber = "gosnomer",
                Busstop = "Учебная",
                DateAndTime = DateTime.Parse("09/12/2016"),
                Waiting = 5,
                FIOdriver = "Петров П.И.",
                FIOconductor = "Петрова Т.Н.",
                FIOdispetcher = "Иванова Р.Г.",
                Earlyend = true,
                LateBeginning = true,
                BigInterval = true,
                BreachShedule = true,
                StopTravel = true,
                ViolationLanding = true,
                OutputWithoutContract = true,
                ViolationOfTrafficPatterns = true,
                VioletionOfTrafficRules = true,
                ConflictWithConductor = true,
                WrongSurrendere = false,
                NotAnnouncedBusstop = false,
                SmokingInCabin = false,
                DiscussionOnPhone = false,
                LoudMusic = false,
                LackOfTickets = false,
                FaultyBus = false,
                SmellOfGus = false,
                PoorSanCondition = false,
                WorkBoards = false,
                WorkSite = false,
                WorkSmsService = false,
                WorkOnLinemap = false,
                WorkMobileApplication = false,
                PoorStateReversalArea = false,
                PoorStateBusstop = false,
                DisadvantageOfInfrastructures = false,
                ConflictWithDispather = false,
                ComplianceWithShedule = false,
                GoodQualityService = false,
                CourteousStaff = false,
                GoodTransportCondition = false

                //= DateTime.Parse("");


            };
            db.Obrashenie.Add(obrashenie1);
            base.Seed(db);
        }
    }
}