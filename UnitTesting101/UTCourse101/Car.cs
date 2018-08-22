using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTCourse101;

namespace UTCourse
{
    public class Car
    {
        public IDictionary<string, Door> Doors;
        public Car(IDictionary<string, Door> _doors)
        {
            Doors = _doors;
        }
    }
}
