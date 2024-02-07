# Cake.Kubectl

A Cake AddIn that extends Cake with [Kubectl](https://kubernetes.io/) command tools.

[![cakebuild.net](https://img.shields.io/badge/WWW-cakebuild.net-blue.svg)](http://cakebuild.net/)
[![NuGet](https://img.shields.io/nuget/v/Cake.Kubectl.svg)](https://www.nuget.org/packages/Cake.Kubectl)

|Branch|Status|
|------|------|
|Master|[![Build status](https://ci.appveyor.com/api/projects/status/github/cake-contrib/Cake.Kubectl?branch=master&svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-kubectl)|
|Develop|[![Build status](https://ci.appveyor.com/api/projects/status/github/cake-contrib/Cake.Kubectl?branch=develop&svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-kubectl)|

## Important
1.1.0
* References Cake 4.0.0
* Drops support for .NET Framework
* Supports .net 6+
* built against Kubectl 1.27.2

1.0.0 This version is built against Kubectl CLI tools version 1.14.

## Including addin
Including addin in cake script is easy.
```
#addin "Cake.Kubectl"
```
## Usage

To use the addin just add it to Cake call the aliases and configure any settings you want.

```csharp
#addin "Cake.Kubectl"

...

// How to login using a token
Task("Create")
    .Does(() => {
        KubectlCreate(new KubectlCreateSettings{ Filename = "path" });
    });
```
Other commands follow same convention.

## Credits

Brought to you by [Miha Markic](https://github.com/MihaMarkic) ([@MihaMarkic](https://twitter.com/MihaMarkic/)) and contributors. 