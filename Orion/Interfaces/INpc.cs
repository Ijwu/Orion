﻿using System;
using Microsoft.Xna.Framework;

namespace Orion.Interfaces
{
	/// <summary>
	/// Provides a wrapper around a Terraria NPC.
	/// </summary>
	public interface INpc
	{
		/// <summary>
		/// Gets the NPC's damage.
		/// </summary>
		int Damage { get; }

		/// <summary>
		/// Gets the NPC's defense.
		/// </summary>
		int Defense { get; }

		/// <summary>
		/// Gets or sets the NPC's health.
		/// </summary>
		int Health { get; set; }

		/// <summary>
		/// Gets or sets the NPC's maximum health.
		/// </summary>
		int MaxHealth { get; set; }

		/// <summary>
		/// Gets the NPC's name.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Gets or sets the NPC's position in the world.
		/// </summary>
		Vector2 Position { get; set; }

		/// <summary>
		/// Gets the NPC's type.
		/// </summary>
		int Type { get; }

		/// <summary>
		/// Gets or sets the NPC's velocity in the world.
		/// </summary>
		Vector2 Velocity { get; set; }

		/// <summary>
		/// Gets the wrapped Terraria NPC.
		/// </summary>
		Terraria.NPC WrappedNpc { get; }

		/// <summary>
		/// Kills the NPC.
		/// </summary>
		void Kill();

		/// <summary>
		/// Sets the NPC's defaults to the specified type's.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="type"/> was an invalid type.</exception>
		void SetDefaults(int type);
	}
}
