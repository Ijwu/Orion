﻿using System;
using NUnit.Framework;
using Orion.Events.Npc;

namespace Orion.Tests.Events.Npc
{
	[TestFixture]
	public class NpcSpawnedEventArgsTests
	{
		[Test]
		public void Constructor_NullNpc_ThrowsException()
		{
			Assert.Throws<ArgumentNullException>(() => new NpcSpawnedEventArgs(null));
		}
	}
}