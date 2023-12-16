namespace Railway.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Constructor_WithValidName_InitializesStation()
        {
            // Arrange
            string stationName = "TestStation";

            // Act
            var station = new RailwayStation(stationName);

            // Assert
            Assert.AreEqual(stationName, station.Name);
            Assert.IsNotNull(station.ArrivalTrains);
            Assert.IsNotNull(station.DepartureTrains);
        }

        [Test]
        public void Constructor_WithNullName_ThrowsArgumentException()
        {
            // Arrange
            string stationName = null;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new RailwayStation(stationName));
        }

        [Test]
        public void Constructor_WithEmptyName_ThrowsArgumentException()
        {
            // Arrange
            string stationName = string.Empty;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new RailwayStation(stationName));
        }

        [Test]
        public void NewArrivalOnBoard_AddsTrainToArrivalQueue()
        {
            // Arrange
            var station = new RailwayStation("TestStation");
            string trainInfo = "Train123";

            // Act
            station.NewArrivalOnBoard(trainInfo);

            // Assert
            Assert.AreEqual(trainInfo, station.ArrivalTrains.Peek());
        }

        [Test]
        public void TrainHasArrived_WithMatchingTrain_MovesToDepartureQueue()
        {
            // Arrange
            var station = new RailwayStation("TestStation");
            string trainInfo = "Train123";
            station.NewArrivalOnBoard(trainInfo);

            // Act
            var result = station.TrainHasArrived(trainInfo);

            // Assert
            Assert.AreEqual(trainInfo, station.DepartureTrains.Peek());
            Assert.IsTrue(result.Contains("is on the platform and will leave in 5 minutes"));
        }

        [Test]
        public void TrainHasLeft_WithMatchingTrain_ReturnsTrue()
        {
            // Arrange
            var station = new RailwayStation("TestStation");
            string trainInfo = "Train123";
            station.NewArrivalOnBoard(trainInfo);
            station.TrainHasArrived(trainInfo);

            // Act
            var result = station.TrainHasLeft(trainInfo);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(station.DepartureTrains.Count == 0);
        }

        [Test]
        public void TrainHasLeft_WithNonMatchingTrain_ReturnsFalse()
        {
            // Arrange
            var station = new RailwayStation("TestStation");
            string trainInfo = "Train123";
            station.NewArrivalOnBoard(trainInfo);

            // Act and Assert
            Assert.IsFalse(station.TrainHasLeft(trainInfo));
            Assert.IsTrue(station.DepartureTrains.Count == 0);
        }

        [Test]
        public void TrainHasArrived_WithNonMatchingTrain_ReturnsErrorMessage()
        {
            // Arrange
            var station = new RailwayStation("TestStation");
            string trainInfo1 = "Train123";
            string trainInfo2 = "Train456";
            station.NewArrivalOnBoard(trainInfo1);

            // Act
            var result = station.TrainHasArrived(trainInfo2);

            // Assert
            Assert.IsTrue(result.Contains($"There are other trains to arrive before {trainInfo2}."));
            Assert.AreEqual(trainInfo1, station.ArrivalTrains.Peek());
        }
    }
}