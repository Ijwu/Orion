﻿using Orion.Framework;

namespace Orion.Configuration
{
	/// <summary>
	/// Provides a generic interface to interact with persistent configuration for plugins
	/// and services without having to deal with where the data loads and saves from.
	/// </summary>
	public interface IConfigurationService : IService
	{
		/// <summary>
		/// Loads a <typeparamref name="TConfig"/> object from the configuration data store.
		/// </summary>
		/// <typeparam name="TService">The service type.</typeparam>
		/// <typeparam name="TConfig">The config type which stores the configuration members.</typeparam>
		/// <returns>
		/// The deserialized <typeparamref name="TConfig"/> object as was loaded from the configuration data store.
		/// </returns>
		TConfig Load<TService, TConfig>()
			where TService : ServiceBase
			where TConfig : class, new();

		/// <summary>
		/// Saves the <typeparamref name="TConfig"/> object to persistent storage.
		/// </summary>
		/// <typeparam name="TService">The service type.</typeparam>
		/// <typeparam name="TConfig">The config type which stores the configuration members.</typeparam>
		void Save<TService, TConfig>(TConfig config)
			where TService : ServiceBase
			where TConfig : class, new();
	}
}
