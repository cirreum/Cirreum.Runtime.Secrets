namespace Microsoft.AspNetCore.Hosting;

using Cirreum.Secrets;
using Cirreum.Secrets.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public static class HostingExtensions {

	private class ConfigureSecretsMarker { }

	/// <summary>
	/// Add support for secrets providers.
	/// </summary>
	public static IHostApplicationBuilder AddSecrets(this IHostApplicationBuilder builder) {

		// Check if already registered using a marker service		
		if (builder.Services.IsMarkerTypeRegistered<ConfigureSecretsMarker>()) {
			return builder;
		}

		// Mark as registered
		builder.Services.MarkTypeAsRegistered<ConfigureSecretsMarker>();

		// Service Providers...
		return builder
			.RegisterSecretsProvider<
				AzureKeyVaultRegistrar,
				AzureKeyVaultSettings,
				AzureKeyVaultInstanceSettings>();

		// .RegisterServiceProvider<AWSSecretsManager>();

	}

}