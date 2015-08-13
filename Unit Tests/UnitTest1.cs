﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orion.Collections;
using System.IO;

namespace Unit_Tests
{
	[TestClass]
	public class WindingNumberTest
	{
		PointCollection pc;

		[TestMethod]
		public void PointTest()
		{
			pc = new PointCollection();
			pc.AddPoint(0, 0);
			pc.AddPoint(0, 10);
			pc.AddPoint(10, 10);
			pc.AddPoint(10, 20);
			pc.AddPoint(15, 15);
			pc.AddPoint(30, 30);
			pc.AddPoint(30, 20);
			pc.AddPoint(20, 10);
			pc.AddPoint(15, 5);
			pc.AddPoint(20, 0);

			//Points can safely be placed in clockwise or anticlockwise order
			pc.ReverseTest();

			Console.WriteLine(pc.IsInArea(5, 5));
			Console.WriteLine(pc.IsInArea(10, 10));
			Console.WriteLine(pc.IsInArea(25, 25));
			Console.WriteLine(pc.IsInArea(15, 16));
			Console.WriteLine(pc.IsInArea(20, 0));

			//Expected   |    Received
			//true            true
			//true            true
			//true            true
			//false           false
			//true            true
		}

		[TestMethod]
		public void FileValidtyTest()
		{
			string path = @"www.this/is//a\path:to^Nowh*&^//\filename.exe";
			
			int index =
				Math.Max(path.LastIndexOfAny(Path.GetInvalidFileNameChars()), path.LastIndexOfAny(Path.GetInvalidPathChars()));
			
			if (index != -1)
			{
				path = path.Substring(index + 1, path.Length - (index + 1));
			}

			path = Path.ChangeExtension(path, ".json");

			Console.WriteLine(path);

			//Expected   |    Received  
			//filename.json   filename.json
		}
	}
}
