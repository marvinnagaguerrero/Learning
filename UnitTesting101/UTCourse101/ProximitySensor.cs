using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTCourse101.interfaces;

namespace UTCourse101
{
    public class ProximitySensor : IProximitySensor //this is a good candidate for Interface
    {
        public bool CheckNearbyKeys()
        {
            return false;
        }
        public bool IsTurnedOn { get; set; } = true;
    }
}
