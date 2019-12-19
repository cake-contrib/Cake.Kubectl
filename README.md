# Cake.Kubernetes

A Cake AddIn that extends Cake with [Kubernetes](https://kubernetes.io/) command tools.

[![cakebuild.net](https://img.shields.io/badge/WWW-cakebuild.net-blue.svg)](http://cakebuild.net/)
[![NuGet](https://img.shields.io/nuget/v/Cake.Kubernetes.svg)](https://www.nuget.org/packages/Cake.Kubernetes)
[![Build status](https://ci.appveyor.com/api/projects/status/vi07dth3d1gek7ak?svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-kubernetes)

## Including addin
Including addin in cake script is easy.
```
#addin "Cake.Kubernetes"
```
## Usage

To use the addin just add it to Cake call the aliases and configure any settings you want.

```csharp
#addin "Cake.Kubernetes"

...

// How to login using a token
Task("Create")
    .Does(() => {
        KubernetesCreate(new KubernetesCreateSettings{ Filename = "path" });
    });
```
Other commands follow same convention.

This version is built against Kubernetes CLI tools version 1.14.

## Credits

Brought to you by [Miha Markic](https://github.com/MihaMarkic) ([@MihaMarkic](https://twitter.com/MihaMarkic/)) and contributors.