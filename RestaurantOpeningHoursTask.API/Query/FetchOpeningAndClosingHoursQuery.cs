using MediatR;
using RestaurantOpeningHoursTask.Shared.OpeningAndClosingHoursModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOpeningHoursTask.API.Query
{
   
    public class FetchOpeningAndClosingHoursQuery : IRequest<OpeningAndClosingHoursResponse>
    {
        public OpeningAndClosingHoursRequest openingAndClosingHoursRequests;
        public FetchOpeningAndClosingHoursQuery(OpeningAndClosingHoursRequest hoursRequests)
        {
            openingAndClosingHoursRequests = hoursRequests;
        }
    }
}
