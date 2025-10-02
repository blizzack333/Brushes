BrushPluginExample with DemoEffect

This package adds DemoEffect.cs (a minimal Paint.NET Effect) so the plugin will appear under Effects -> Demo when compiled locally.
Build notes:
- The project references Paint.NET assemblies from C:\Program Files\paint.net\. Ensure those are present on the build machine.
- To build locally, open the .csproj in Visual Studio, add the Paint.NET references if needed, and build Release/x64.
- If you want me to build it via CI, invite 'assistant' as a repo collaborator and ensure Paint.NET assemblies are available to the build environment (not present by default on GitHub runners).
