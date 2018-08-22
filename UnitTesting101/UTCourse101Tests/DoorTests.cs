using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTCourse101;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using UTCourse;
using UTCourse101.interfaces;
using Shouldly;

namespace UTCourse101.Tests
{
    [TestClass()]
    public class DoorTests
    {
        [TestMethod()]

        public void CarDoor_WhenDoorIsClosedAndProximityKeyIsNearBy_OnOpenDoor_ShouldOpen()
        {
            //ARRANGE
            var mockedSensor = Substitute.For<IProximitySensor>();
            mockedSensor.IsTurnedOn = true;
            mockedSensor.CheckNearbyKeys().Returns(true);
            var lockmechanism = new LockingMechanism(mockedSensor);
            var Doors = new Dictionary<string, Door>()
                        {
                             {"FrontLeft", new Door(lockmechanism)},
                             {"FrontRight", new Door(lockmechanism)},
                             {"RearLeft", new Door(lockmechanism)},
                             {"RearRight", new Door(lockmechanism)}
                        };
            var picanto = new Car(Doors);

            // ACT
            picanto.Doors["FrontLeft"].Open();


            // ASSERT
            Assert.AreEqual(picanto.Doors["FrontLeft"].CurrentState, "Opened");
            picanto.Doors["FrontLeft"].CurrentState.ShouldBe("Opened");
        }


        [TestMethod()]

        public void CarDoorWhenDoorIsClosedAndNoProximityKeyPresent_OnOpenDoor_ShouldNotOpen()
        {
            //ARRANGE
            var mockedSensor = Substitute.For<IProximitySensor>();
            mockedSensor.IsTurnedOn = true;
            var lockmechanism = new LockingMechanism(mockedSensor);
            var Doors = new Dictionary<string, Door>()
                       {
                            {"FrontLeft", new Door(lockmechanism)},
                       };
            var picanto = new Car(Doors);

            // ACT
            picanto.Doors["FrontLeft"].Open();


            // ASSERT
            Assert.AreEqual(picanto.Doors["FrontLeft"].CurrentState, "Closed");
            picanto.Doors["FrontLeft"].CurrentState.ShouldBe("Closed");
        }
    }
}