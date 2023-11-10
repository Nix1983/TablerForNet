[![CodeQL](https://github.com/Nix1983/TablerForNet/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/Nix1983/TablerForNet/actions/workflows/github-code-scanning/codeql)
[![Auto Increment Version](https://github.com/Nix1983/TablerForNet/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Nix1983/TablerForNet/actions/workflows/dotnet.yml)
![NuGet](https://img.shields.io/nuget/v/TablerForNet.svg)

# TablerForNet: Create SEO-optimized web apps.

TablerForNet is a versatile and SEO-optimized library for building web applications using Blazor. It is based on the Tabler UI framework and aims to provide developers with a set of components and tools to create modern and responsive user interfaces.

## Features

- Seamlessly integrates with Blazor projects.
- Leverages the Tabler CSS framework for consistent and aesthetic designs.
- Offers a collection of components tailored for Blazor development.
- Focuses on SEO optimization to ensure better search engine visibility.
- Simplifies the process of creating responsive web applications.

## Installtion

Install nuget package tablerForNet

`dotnet add package TablerForNet`


Add to file Program.cs

`using TablerForNet;`

`builder.Services.AddTablerForNet();`



Add to file _Host.cshtml

`<link href="_content/TablerForNet/css/tablerForNet.min.css" rel="stylesheet"/>`

`<script src="_content/TablerForNet/js/tablerForNet.min.js"></script>`


Add to file _Imports.razor

`@using TablerForNet`

`@using TablerForNet.Icons`

`@using TablerForNet.Flags`

`@using TablerForNet.Components`


[More information](https://ghostlyInc.com/en-US/tabler-for-net-and-balzor-usage/)
  
## Example Page

This example page was created using TablerForNet, a versatile and SEO-friendly library for building web applications with Blazor. TablerForNet offers a collection of components and tools that enable the creation of modern and responsive user interfaces, while maintaining a strong focus on search engine optimization (SEO).

Explore the [Example Page](https://ghostlyInc.com) and discover the powerful features of TablerForNet, providing seamless integration with Blazor projects and ensuring your web applications are optimally visible to search engines.


