using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class ApptRepository
    {
        private readonly Dictionary<int, Appointment> appt = new Dictionary<int, Appointment>();

        public Task<List<IAppointment>> GetAppointments()
        {
            // var apptList = appt.Values.ToList();
            return Task.Run(() => appt.Values.Select(appt.ToList());
        }
    }
}
