using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastEpochShared.Services
{
    public static class EventService
    {
        public static event EventHandler<string> CallPageSwitch;

        public static void ChangePage(string nameOfPage)
        {
            if (string.IsNullOrEmpty(nameOfPage))
            {
                return;
            }

            CallPageSwitch?.Invoke(null, nameOfPage);
        }
    }
}
