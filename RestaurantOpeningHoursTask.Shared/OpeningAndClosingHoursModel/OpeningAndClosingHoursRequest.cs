using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOpeningHoursTask.Shared.OpeningAndClosingHoursModel
{
    
    public class OpenHourPayload
    {
        public string Type { get; set; }
        public int Value { get; set; }
    }

    public class OpeningAndClosingHoursRequest
    {
        public List<OpenHourPayload> Monday { get; set; }
        public List<OpenHourPayload> Tuesday { get; set; }
        public List<OpenHourPayload> Wednesday { get; set; }
        public List<OpenHourPayload> Thursday { get; set; }
        public List<OpenHourPayload> Friday { get; set; }
        public List<OpenHourPayload> Saturday { get; set; }
        public List<OpenHourPayload> Sunday { get; set; }
    }
}
