using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTCourse101.interfaces;

namespace UTCourse101
{
    public class LockingMechanism  //proximity sensor is now using iProximitySensor
    {
        public bool IsLocked { get; set; } = true;
        public IProximitySensor Sensor { get; set; }
        public LockingMechanism(IProximitySensor _sensor)
        {
            Sensor = _sensor;
        }
    }

}
