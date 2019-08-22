using System;
using System.Linq.Expressions;

namespace Projekt.Models.ViewModel
{
    public class EngagementDetails
    {
        public int Id {get;set;}

        public int ActorId {get;set;}
        public int MovieId {get;set;}
        public decimal Fee {get;set;}

        public static Expression<Func<Engagement, EngagementDetails>> Projection
        {
            get
            {
                return engagement => new EngagementDetails
                {
                    Id = engagement.Id,
                    ActorId = engagement.ActorId,
                    MovieId = engagement.MovieId,
                    Fee = engagement.Fee
                };
            }
        }

        public static EngagementDetails Create(Engagement engagement)
        {
            return Projection.Compile().Invoke(engagement);
        }
    }
}