## What it is

This demo project is for support of [this discussion post](https://bitbucket.org/Unity-Technologies/networking/pull-requests/1/performance-optimization/diff#comment-12637913) regarding performance impact when using Foreach.

The conclusion of this demo is:

**Using foreach in a dll project will not bring performance lost**

Thus, NO NEED to replace Foreach in a dll project.

- - -
## How to run

- open ForeachDll solution in Monodevelop/Visual Studio, and build the project. The output dll will be copied automatically to Unity project
- open ForeachDemo project in Unity, open "TestScene" under "Scenes" folder
- open 'Profiler' window of Unity
- run Unity editor, after several frames, click on 'Profiler' to observe the result (should be as below)
![Profiler Window](https://github.com/frank28/ForeachDemo/blob/master/ScreenShots/Profiler.png?raw=true)
- notice that, only "ForeachCompiled_InUnity" caused '40B' gc alloc, which is caused by a 'cast struct to interface'

