﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bogoraz;
using Bogoraz.Utils;

namespace Bogoraz.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestImageCoverter()
        {
            ImageConverter imagecnv = new ImageConverter();
            string imageData = "data:image/png;base64,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";
            string outputPath = AppDomain.CurrentDomain.BaseDirectory;
            imagecnv.SaveByteArrayAsImage(outputPath, imageData);
        }
    }
}