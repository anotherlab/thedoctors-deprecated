using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors.Models
{
    public class DoctorActor
    {
        public string Actor { get; set; }
        public string Incarnation { get; set; }

        public int? Seasons { get; set; }

        public DateTime StartDate { get; set; }

        public int Age { get; set; }

        public string ImageUrl { get; set; }
    }

    public static class DoctorFactory
    {
        public static List<DoctorActor> Doctors { get; private set; }

        static DoctorFactory()
        {
            Doctors = GetDoctors();
        }
        public static List<DoctorActor> GetDoctors()
        {
            return new List<DoctorActor>()
            {
                new DoctorActor
                {
                    Actor = "William Hartnell",
                    Age = 58,
                    Incarnation = "First Doctor",
                    Seasons = 4,
                    ImageUrl = "WilliamHartnell.png",
                    StartDate = DateTime.ParseExact("19631123", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "Patrick Troughton",
                    Age = 46,
                    Incarnation = "Second Doctor",
                    Seasons = 3,
                    ImageUrl = "PatrickTroughton.png",
                    StartDate = DateTime.ParseExact("19661029", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "Jon Pertwee",
                    Age = 50,
                    Incarnation = "Third Doctor",
                    Seasons = 5,
                    ImageUrl = "JonPertwee.png",
                    StartDate = DateTime.ParseExact("19700103", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "Tom Baker",
                    Age = 40,
                    Incarnation = "Fourth Doctor",
                    Seasons = 7,
                    ImageUrl = "TomBaker.png",
                    StartDate = DateTime.ParseExact("19740608", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "Peter Davison",
                    Age = 29,
                    Incarnation = "Fifth Doctor",
                    Seasons = 3,
                    ImageUrl = "PeterDavison.png",
                    StartDate = DateTime.ParseExact("19810321", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "Colin Baker",
                    Age = 40,
                    Incarnation = "Sixth Doctor",
                    Seasons = 3,
                    ImageUrl = "ColinBaker.png",
                    StartDate = DateTime.ParseExact("19840316", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "Sylvester McCoy",
                    Age = 42,
                    Seasons = 3,
                    Incarnation = "Seventh Doctor",
                    ImageUrl = "SylvesterMcCoy.png",
                    StartDate = DateTime.ParseExact("19870907", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "Paul McGann",
                    Age = 36,
                    Incarnation = "Eighth Doctor",
                    ImageUrl = "PaulMcGann.png",
                    StartDate = DateTime.ParseExact("19960527", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "John Hurt",
                    Age = 73,
                    Seasons = 1,
                    Incarnation = "War Doctor",
                    ImageUrl = "JohnHurt.png",
                    StartDate = DateTime.ParseExact("20130518", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "Christopher Eccleston",
                    Age = 41,
                    Incarnation = "Ninth Doctor",
                    ImageUrl = "ChristopherEccleston.png",
                    Seasons = 1,
                    StartDate = DateTime.ParseExact("20050618", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "David Tennant",
                    Age = 34,
                    Incarnation = "Tenth Doctor",
                    ImageUrl = "DavidTennant.png",
                    Seasons = 3,
                    StartDate = DateTime.ParseExact("20050618", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "Matt Smith",
                    Age = 27,
                    Incarnation = "Eleventh Doctor",
                    ImageUrl = "MattSmith.png",
                    Seasons = 3,
                    StartDate = DateTime.ParseExact("20100101", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new DoctorActor
                {
                    Actor = "Pater Capaldi",
                    Age = 40,
                    Incarnation = "Twelfth Doctor",
                    ImageUrl = "PeterCapaldi.png",
                    StartDate = DateTime.ParseExact("20131225", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
            };
        }
    }
}
