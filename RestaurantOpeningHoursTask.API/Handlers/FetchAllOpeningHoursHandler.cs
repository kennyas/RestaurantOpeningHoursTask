using MediatR;
using RestaurantOpeningHoursTask.API.BusinessLogic;
using RestaurantOpeningHoursTask.API.Query;
using RestaurantOpeningHoursTask.Shared.OpeningAndClosingHoursModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantOpeningHoursTask.API.Handlers
{
   
    public class FetchAllOpeningHoursHandler : IRequestHandler<FetchOpeningAndClosingHoursQuery, OpeningAndClosingHoursResponse>
    {

        public FetchAllOpeningHoursHandler()
        {

        }
        public Task<OpeningAndClosingHoursResponse> Handle(FetchOpeningAndClosingHoursQuery request, CancellationToken cancellationToken)
        {
            var TimeConverter = new UnixTimeConverter();
            return Task.FromResult(TimeConverter.UnixConverter(request.openingAndClosingHoursRequests));
        }
    }
}
