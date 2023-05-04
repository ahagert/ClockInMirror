using ClockInMirrorLib;

namespace ClockInMirrorLib.Tests;

[TestFixture]
public class ClockInMirrorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Result_of_1200_should_be_1200()
    {
        var mirroredTime = MirrorTimeConverter.WhatIsTheTime("12:00");
        var result = (mirroredTime == "12:00");
        Assert.IsFalse(!result, "12:00 in the mirror should be 12:00 in reality.");
    }

    [Test]
    public void Result_of_0600_should_be_0600()
    {
        var mirroredTime = MirrorTimeConverter.WhatIsTheTime("06:00");
        var result = (mirroredTime == "06:00");
        Assert.IsFalse(!result, "06:00 in the mirror should be 06:00 in reality.");
    }

    [Test]
    public void Result_of_0300_should_be_0900()
    {
        var mirroredTime = MirrorTimeConverter.WhatIsTheTime("03:00");
        var result = (mirroredTime == "09:00");
        Assert.IsFalse(!result, "03:00 in the mirror should be 09:00 in reality.");
    }

    [Test]
    public void Result_of_0900_should_be_0300()
    {
        var mirroredTime = MirrorTimeConverter.WhatIsTheTime("09:00");
        var result = (mirroredTime == "03:00");
        Assert.IsFalse(!result, "09:00 in the mirror should be 03:00 in reality.");
    }

    [Test]
    public void Result_of_1201_should_be_1159()
    {
        var mirroredTime = MirrorTimeConverter.WhatIsTheTime("12:01");
        var result = (mirroredTime == "11:59");
        Assert.IsFalse(!result, "12:01 in the mirror should be 11:59 in reality.");
    }

    [Test]
    public void Result_of_1159_should_be_1201()
    {
        var mirroredTime = MirrorTimeConverter.WhatIsTheTime("11:59");
        var result = (mirroredTime == "12:01");
        Assert.IsFalse(!result, "11:59 in the mirror should be 12:01 in reality.");
    }

    [Test]
    public void Result_of_1222_should_be_1138()
    {
        var mirroredTime = MirrorTimeConverter.WhatIsTheTime("12:22");
        var result = (mirroredTime == "11:38");
        Assert.IsFalse(!result, "12:22 in the mirror should be 11:38 in reality.");
    }

    [Test]
    public void Result_of_1138_should_be_1222()
    {
        var mirroredTime = MirrorTimeConverter.WhatIsTheTime("11:38");
        var result = (mirroredTime == "12:22");
        Assert.IsFalse(!result, "11:38 in the mirror should be 12:22 in reality.");
    }
}