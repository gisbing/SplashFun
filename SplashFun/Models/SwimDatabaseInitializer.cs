using System.Collections.Generic;
using System.Data.Entity;

namespace SplashFun.Models
{
    public class SwimDatabaseInitializer : DropCreateDatabaseAlways<SwimContext>
    {
        protected override void Seed(SwimContext context)
        {
            //base.Seed(context);
            SeededStrokes().ForEach(s => context.Strokes.Add(s));
            SeededDistances().ForEach(d => context.Distances.Add(d));
            SeededTeams().ForEach(t => context.Teams.Add(t));
            SeededSwimmers().ForEach(s => context.Swimmers.Add(s));
            SeededTimeRecord().ForEach(s => context.TimeRecords.Add(s));
        }

        private static List<Team> SeededTeams()
        {
            var teams = new List<Team> {
                new Team {
                    TeamID = 1,
                    Name = "RMSC",
                    Logo = "team_rmsc.jpg"
                }
            };
            return teams;
        }
        private static List<Swimmer> SeededSwimmers()
        {
            var swimmers = new List<Swimmer> {
                new Swimmer {
                   SwimmerID = 1,
                   LastName = "Smith",
                   FirstName = "John",
                   Age = 15,
                   Gender = "M",
                   Avatar = "jsmith.jpg",
                   TeamID =  1
                },
                new Swimmer {
                   SwimmerID = 2,
                   LastName = "Brian",
                   FirstName = "Wang",
                   Age = 14,
                   Gender = "M",
                   Avatar = "wbrian.jpg",
                   TeamID =  1
                },
                new Swimmer {
                   SwimmerID = 3,
                   LastName = "Sun",
                   FirstName = "Lynn",
                   Age = 17,
                   Gender = "F",
                   Avatar = "slynn.jpg",
                   TeamID =  1
                }
            };
            return swimmers;
        }


        private static List<Stroke> SeededStrokes()
        {
            var strokes = new List<Stroke>{
                new Stroke {
                    StrokeID = 1,
                    StrokeName = "Free"
                },
                new Stroke {
                    StrokeID = 2,
                    StrokeName = "Back"
                },
                new Stroke {
                    StrokeID = 3,
                    StrokeName = "Breast"
                },
                new Stroke {
                    StrokeID = 4,
                    StrokeName = "ButterFly"
                }
            };
            return strokes;
        }
        private static List<Distance> SeededDistances()
        {
            var distances = new List<Distance>{
                new Distance {
                    DistanceID = 1,
                    Measure = 25
                },
                new Distance {
                    DistanceID = 2,
                    Measure = 50
                },
                new Distance {
                    DistanceID = 3,
                    Measure = 100
                },
                new Distance {
                    DistanceID = 4,
                    Measure = 200
                },
                new Distance {
                    DistanceID = 5,
                    Measure = 400
                },
                new Distance {
                    DistanceID = 6,
                    Measure = 800
                },
                new Distance {
                    DistanceID = 7,
                    Measure = 1500
                }
            };
            return distances;
        }

        private static List<TimeRecord> SeededTimeRecord()
        {
            var records = new List<TimeRecord>{
                new TimeRecord {
                    SwimmerID = 1,
                    StrokeID = 1,
                    DistanceID = 1,
                    Record = "26:20"
                }
            };
            return records;
        }
    }

}