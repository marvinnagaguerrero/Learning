using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTCourse101
{
    public class Door
    {
        private bool _isOpened { get; set; }
        public string CurrentState { get { if (_isOpened) return "Opened"; else return "Closed"; } }

        private LockingMechanism DoorHandle { get; set; }

        public Door(LockingMechanism _lockmechanism)
        {
            this.DoorHandle = _lockmechanism;
        }

        public bool Open()
        {
            if (!DoorHandle.IsLocked)
                return _isOpened = true;
            else
                if (DoorHandle.Sensor.IsTurnedOn && DoorHandle.Sensor.CheckNearbyKeys())
                return _isOpened = true;
            else
                return _isOpened = false;

        }

        public bool Close()
        {
            return _isOpened = false;
        }

    }
}
