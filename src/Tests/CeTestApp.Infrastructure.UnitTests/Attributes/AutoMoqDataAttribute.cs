﻿using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace CeTestApp.Infrastructure.UnitTests.Attributes;

public class AutoMoqDataAttribute : AutoDataAttribute
{
    public AutoMoqDataAttribute()
        : base(new Fixture()
            .Customize(new AutoMoqCustomization()))
    { }
}