# Cirreum.Runtime.Secrets

[![NuGet Version](https://img.shields.io/nuget/v/Cirreum.Runtime.Secrets.svg?style=flat-square&labelColor=1F1F1F&color=003D8F)](https://www.nuget.org/packages/Cirreum.Runtime.Secrets/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Cirreum.Runtime.Secrets.svg?style=flat-square&labelColor=1F1F1F&color=003D8F)](https://www.nuget.org/packages/Cirreum.Runtime.Secrets/)
[![GitHub Release](https://img.shields.io/github/v/release/cirreum/Cirreum.Runtime.Secrets?style=flat-square&labelColor=1F1F1F&color=FF3B2E)](https://github.com/cirreum/Cirreum.Runtime.Secrets/releases)
[![License](https://img.shields.io/github/license/cirreum/Cirreum.Runtime.Secrets?style=flat-square&labelColor=1F1F1F&color=F2F2F2)](https://github.com/cirreum/Cirreum.Runtime.Secrets/blob/main/LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10.0-003D8F?style=flat-square&labelColor=1F1F1F)](https://dotnet.microsoft.com/)

**Seamless secrets management for Cirreum Runtime applications**

## Overview

**Cirreum.Runtime.Secrets** provides a unified configuration interface for integrating secrets providers into ASP.NET Core applications. It simplifies the process of adding secure secret management capabilities with minimal configuration.

## Features

- Simple extension method for ASP.NET Core host builder
- Built-in Azure Key Vault integration
- Automatic duplicate registration prevention
- Follows Cirreum Foundation Framework patterns

## Installation

```bash
dotnet add package Cirreum.Runtime.Secrets
```

## Usage

Add secrets management to your ASP.NET Core application:

```csharp
var builder = WebApplication.CreateBuilder(args);

// Add secrets provider support
builder.AddSecrets();

var app = builder.Build();
```

The `AddSecrets()` extension method automatically:
- Registers Azure Key Vault as the default secrets provider
- Prevents duplicate registrations using marker types
- Configures all necessary services for secrets management

## Supported Providers

Currently supported:
- Azure Key Vault (via `Cirreum.Secrets.Azure`)

Future support planned:
- AWS Secrets Manager

## Contribution Guidelines

1. **Be conservative with new abstractions**  
   The API surface must remain stable and meaningful.

2. **Limit dependency expansion**  
   Only add foundational, version-stable dependencies.

3. **Favor additive, non-breaking changes**  
   Breaking changes ripple through the entire ecosystem.

4. **Include thorough unit tests**  
   All primitives and patterns should be independently testable.

5. **Document architectural decisions**  
   Context and reasoning should be clear for future maintainers.

6. **Follow .NET conventions**  
   Use established patterns from Microsoft.Extensions.* libraries.

## Versioning

Cirreum.Runtime.Secrets follows [Semantic Versioning](https://semver.org/):

- **Major** - Breaking API changes
- **Minor** - New features, backward compatible
- **Patch** - Bug fixes, backward compatible

Given its foundational role, major version bumps are rare and carefully considered.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

**Cirreum Foundation Framework**  
*Layered simplicity for modern .NET*