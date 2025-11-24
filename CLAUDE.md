# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

### Build
```bash
dotnet build Cirreum.Runtime.Secrets.slnx --configuration Release
```

### Pack NuGet Package
```bash
dotnet pack Cirreum.Runtime.Secrets.slnx --configuration Release -p:Version=1.0.0
```

### Restore Dependencies
```bash
dotnet restore Cirreum.Runtime.Secrets.slnx
```

### Local Development Build
For local development, the project will use version 1.0.100-rc by default when building in Release mode.

## Architecture

This is a Cirreum Runtime extension that provides secrets provider configuration integration for ASP.NET Core applications. The project follows the Cirreum Foundation Framework pattern of "layered simplicity for modern .NET".

### Key Components

- **HostingExtensions**: Extension methods for `IHostApplicationBuilder` that register secrets providers
  - Located in `src/Cirreum.Runtime.Secrets/Extensions/Hosting/HostingExtensions.cs`
  - Provides `AddSecrets()` method that registers Azure Key Vault as the default secrets provider
  - Uses marker types to prevent duplicate registrations

### Dependencies
- Targets .NET 10.0
- Depends on:
  - `Cirreum.Secrets.Azure` (1.0.1) - Azure Key Vault implementation
  - `Cirreum.Runtime.SecretsProvider` (1.0.1) - Core secrets provider abstractions

### Build Configuration
- Uses MSBuild property imports from the `/build` directory for common settings
- Supports CI/CD detection for Azure DevOps and GitHub Actions
- Generates documentation files and NuGet packages
- Uses semantic versioning with automatic version extraction from git tags

### Extension Pattern
The project extends the `Microsoft.AspNetCore.Hosting` namespace to provide seamless integration with ASP.NET Core's hosting model. This allows developers to easily add secrets management with a simple `builder.AddSecrets()` call.