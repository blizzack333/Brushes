How to use this repository to build the plugin with GitHub Actions (Windows runner)

1) Create a new GitHub repository and push these files to the repo root.
2) Ensure default branch is 'main'.
3) Go to GitHub → Actions, open 'Build BrushPlugin (Windows)' and run it or push to main to trigger.
4) After a successful run, download the artifact named 'BrushPlugin-build'.
   Inside the artifact you'll find the compiled DLL in bin\Release.
5) Copy the compiled DLL to:
   C:\Program Files\paint.net\Effects\
   (Admin rights required.)
6) Restart Paint.NET.

Notes:
- The scaffold compiles without Paint.NET assemblies because it doesn't call Paint.NET APIs directly.
- If you modify the project to reference Paint.NET assemblies, you'll need to include them in the repo or otherwise supply them at build time.
