﻿namespace ScottPlotTests.UnitTests;

internal class VersionTests
{
    [Test]
    public void Test_Version_Numbers_Valid()
    {
        ScottPlot.Version.InformalVersion.Should().NotBeNullOrWhiteSpace();
        ScottPlot.Version.Major.Should().BeGreaterThanOrEqualTo(5);
        ScottPlot.Version.Minor.Should().BeGreaterThanOrEqualTo(0);
        ScottPlot.Version.Build.Should().BeGreaterThanOrEqualTo(0);
    }
}
