﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using PrismRefitTutorial.UITests.Pages;

namespace PrismRefitTutorial.UITests.Tests
{
    public class MainPageTests : AbstractSetup
    {
        public Tests(Platform platform)
            : base(platform)
        {
        }

        [Test]
        public void DidAppStart()
        {
            var mainPage = new MainPage();
            mainPage.AppStarted();
        }
    }
}
