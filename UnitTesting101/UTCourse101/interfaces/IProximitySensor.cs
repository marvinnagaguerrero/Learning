using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTCourse101.interfaces
{
    public interface IProximitySensor  //the cornerstone of writing testable codes
    {
        bool CheckNearbyKeys();
        bool IsTurnedOn { get; set; }
    }
}
