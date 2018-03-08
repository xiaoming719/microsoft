NET Core Libraries (CoreFX)

This repo contains the library implementation (called "CoreFX") for .NET Core. It includes System.Collections, System.IO, System.Xml, and many other components. The corresponding .NET Core Runtime repo (called "CoreCLR") contains the runtime implementation for .NET Core. It includes RyuJIT, the .NET GC, and many other components. Runtime-specific library code (mscorlib) lives in the CoreCLR repo. It needs to be built and versioned in tandem with the runtime. The rest of CoreFX is agnostic of runtime-implementation and can be run on any compatible .NET runtime (e.g. CoreRT).

.NET Core

Official Starting Page: http://dotnet.github.io

How to use .NET Core (with VS, VS Code, command-line CLI)
Install official releases
Documentation (Get Started, Tutorials, Porting from .NET Framework, API reference, ...)
Deploying apps
Supported OS versions
Roadmap
Releases
Bringing more APIs to .NET Core (and why some APIs will be left out)
How to Engage, Contribute and Provide Feedback

Some of the best ways to contribute are to try things out, file bugs, join in design conversations, and fix issues.

Dogfooding daily builds
If you have a question or idea, file a new issue.
If you are having issues with the "full" .NET Framework (also called "Desktop"), the best way to file a bug is the Report a Problem tool, which is integrated with the VS Developer Community Portal; or through Product Support if you have a contract.

Issue Guide

This section is in progress here: New contributor Docs - Issues (feel free to make it better - it's easy-to-edit wiki with RW permissions to everyone!)

Each issue area has one or more Microsoft owners, who are listed here.

Contributing Guide

This section is in progress here: New contributor Docs - Contributing (feel free to make it better - it's easy-to-edit wiki with RW permissions to everyone!)

Useful Links

.NET Core source index / .NET Framework source index
API Reference docs
.NET API Catalog (incl. APIs from daily builds and API usage info)
Community

General .NET OSS discussions: .NET Foundation forums
Chat with other community members Join the chat at https://gitter.im/dotnet/corefx .NET Slack Status
This project has adopted the code of conduct defined by the Contributor Covenant to clarify expected behavior in our community. For more information, see the .NET Foundation Code of Conduct.

Reporting security issues and security bugs

Security issues and bugs should be reported privately, via email, to the Microsoft Security Response Center (MSRC) secure@microsoft.com. You should receive a response within 24 hours. If for some reason you do not, please follow up via email to ensure we received your original message. Further information, including the MSRC PGP key, can be found in the Security TechCenter.

Also see info about related Microsoft .NET Core and ASP.NET Core Bug Bounty Program.

License

.NET Core (including the corefx repo) is licensed under the MIT license.

.NET Foundation

.NET Core is a .NET Foundation project.

There are many .NET related projects on GitHub.

.NET home repo - links to 100s of .NET projects, from Microsoft and the community.
ASP.NET Core home - the best place to start learning about ASP.NET Core.
CoreFX Project

Daily Builds

Daily builds of .NET Core components are published to dotnet-core MyGet gallery. The latest version number of each library can be seen in that gallery.

Build & Test Status

Note: See officially supported OS versions.
