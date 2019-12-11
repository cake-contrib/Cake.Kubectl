# Cake.Kubernetes

[![standard-readme compliant][]][standard-readme]
[![All Contributors](https://img.shields.io/badge/all_contributors-0-orange.svg?style=flat-square)](#contributors)
[![Appveyor build][appveyorimage]][appveyor]
[![Travis build][travisimage]][travis]
[![Codecov Report][codecovimage]][codecov]
[![NuGet package][nugetimage]][nuget]

> A Cake addin for Kubernetes

## Table of Contents

- [Install](#install)
- [Usage](#usage)
- [Maintainer](#maintainer)
- [Contributing](#contributing)
  - [Contributors](#contributors)
- [License](#license)

## Install

```cs
#addin nuget:?package=Cake.Kubernetes
```

## Usage

```cs
#addin nuget:?package=Cake.Kubernetes

Task("MyTask").Does(() => {
  Kubernetes();
});
```

## Maintainer

[Roma Marusyk @Marusyk][maintainer]

## Contributing

Cake.Kubernetes follows the [Contributor Covenant][contrib-covenant] Code of Conduct.

We accept Pull Requests.
Please see [the contributing file][contributing] for how to contribute to Cake.Kubernetes.

Small note: If editing the Readme, please conform to the [standard-readme][] specification.

This project follows the [all-contributors][] specification. Contributions of any kind welcome!

### Contributors

Thanks goes to these wonderful people ([emoji key][emoji-key]):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore -->
<!-- ALL-CONTRIBUTORS-LIST:END -->

## License

[MIT License © Roma Marusyk][license]

[all-contributors]: https://github.com/all-contributors/all-contributors
[appveyor]: https://ci.appveyor.com/project/roman marusyk/cake-kubernetes
[appveyorimage]: https://img.shields.io/appveyor/ci/roman marusyk/cake-kubernetes.svg?logo=appveyor&style=flat-square
[codecov]: https://codecov.io/gh/Roman Marusyk/Cake.Kubernetes
[codecovimage]: https://img.shields.io/codecov/c/github/Roman Marusyk/Cake.Kubernetes.svg?logo=codecov&style=flat-square
[contrib-covenant]: https://www.contributor-covenant.org/version/1/4/code-of-conduct
[contributing]: CONTRIBUTING.md
[emoji-key]: https://allcontributors.org/docs/en/emoji-key
[maintainer]: https://github.com/Marusyk
[nuget]: https://nuget.org/packages/Cake.Kubernetes
[nugetimage]: https://img.shields.io/nuget/v/Cake.Kubernetes.svg?logo=nuget&style=flat-square
[license]: LICENSE
[standard-readme]: https://github.com/RichardLitt/standard-readme
[standard-readme compliant]: https://img.shields.io/badge/readme%20style-standard-brightgreen.svg?style=flat-square
[travis]: https://travis-ci.org/Roman Marusyk/Cake.Kubernetes
[travisimage]: https://img.shields.io/travis/Roman Marusyk/Cake.Kubernetes.svg?logo=travis&style=flat-square
