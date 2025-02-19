﻿namespace Refitter.Tests.Build;

public static class ProjectFileContents
{
    public const string Net70App = @"
<Project Sdk=""Microsoft.NET.Sdk"">
  <PropertyGroup>
    <TargetFramework>net70</TargetFramework>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include=""Refit"" Version=""6.3.2"" />
    <PackageReference Include=""Newtonsoft.Json"" Version=""13.0.1"" />
    <PackageReference Include=""System.ComponentModel.Annotations"" Version=""4.5.0"" />
    <PackageReference Include=""System.Runtime.Serialization.Primitives"" Version=""4.3.0"" />
  </ItemGroup>
</Project>";
}