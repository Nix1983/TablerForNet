<a href="https://www.nuget.org/packages/TablerForNet/" target="_blank" rel="noopener noreferrer">
    <img alt="NuGet" src="https://img.shields.io/nuget/v/TablerForNet.svg">
</a>

# TablerForNet

TablerForNet is a versatile and SEO-optimized library for building web applications using Blazor. It is based on the Tabler UI framework and aims to provide developers with a set of components and tools to create modern and responsive user interfaces.

## Features

- Seamlessly integrates with Blazor projects.
- Leverages the Tabler CSS framework for consistent and aesthetic designs.
- Offers a collection of components tailored for Blazor development.
- Focuses on SEO optimization to ensure better search engine visibility.
- Simplifies the process of creating responsive web applications.

## Installtion

Install nuget package tablerForNet
<pre>
  dotnet add package TablerForNet --version 1.0.6
</pre>

Add to file Program.cs
<pre>
using TablerForNet;

builder.Services.AddTablerForNet(); 
</pre>


Add to file _Host.cshtml

`<link href="_content/TablerForNet/css/tablerForNet.min.css" rel="stylesheet"/>`

`<script src="_content/TablerForNet/js/tablerForNet.min.js"></script>`


Add to file _Imports.razor
<pre>
@using TablerForNet.Icons
@using TablerForNet.Flags
@using TablerForNet.Components
</pre>

[More information](https://ghostlyInc.com/en-US/tabler-for-net-and-balzor-usage/)
  
## Example Page

This example page was created using TablerForNet, a versatile and SEO-friendly library for building web applications with Blazor. TablerForNet offers a collection of components and tools that enable the creation of modern and responsive user interfaces, while maintaining a strong focus on search engine optimization (SEO).

Explore the [Example Page](https://ghostlyInc.com) and discover the powerful features of TablerForNet, providing seamless integration with Blazor projects and ensuring your web applications are optimally visible to search engines.


