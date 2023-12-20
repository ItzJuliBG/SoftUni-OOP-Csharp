using NUnit.Framework;
using Television;

namespace Television.Tests
{
    [TestFixture]
    public class TelevisionDeviceTests
    {
        [Test]
        public void SwitchOn_ReturnsCorrectString()
        {
            var tv = new TelevisionDevice("Sony", 500, 1920, 1080);
            string result = tv.SwitchOn();
            Assert.AreEqual($"Cahnnel {tv.CurrentChannel} - Volume {tv.Volume} - Sound On", result);
        }

        [Test]
        public void ChangeChannel_UpdatesCurrentChannel()
        {
            var tv = new TelevisionDevice("Samsung", 600, 1280, 720);
            int newChannel = tv.ChangeChannel(5);
            Assert.AreEqual(5, newChannel);
        }

        [Test]
        public void VolumeChange_IncreasesVolume()
        {
            var tv = new TelevisionDevice("LG", 700, 2560, 1440);
            string result = tv.VolumeChange("UP", 10);
            Assert.AreEqual("Volume: 23", result);
        }

        [Test]
        public void VolumeChange_DecreasesVolume()
        {
            var tv = new TelevisionDevice("Panasonic", 800, 3840, 2160);
            string result = tv.VolumeChange("DOWN", 5);
            Assert.AreEqual("Volume: 8", result);
        }

        [Test]
        public void MuteDevice_TogglesMutedState()
        {
            var tv = new TelevisionDevice("Sony", 500, 1920, 1080);
            bool initialMutedState = tv.IsMuted;
            bool result = tv.MuteDevice();
            Assert.AreNotEqual(initialMutedState, result);
        }

        [Test]
        public void ToString_ReturnsCorrectString()
        {
            var tv = new TelevisionDevice("Samsung", 600, 1280, 720);
            string result = tv.ToString();
            Assert.AreEqual("TV Device: Samsung, Screen Resolution: 1280x720, Price 600$", result);
        }
    }
}
