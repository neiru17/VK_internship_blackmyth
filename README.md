# Black Myth: Wukong Benchmark Automation

C# console application for launching Black Myth: Wukong Benchmark Tool
and running CPU-oriented and GPU-oriented benchmark passes.

## Requirements

- Windows 10/11
- Visual Studio 2022
- .NET 8
- Steam
- Black Myth: Wukong Benchmark Tool

## How to run

1. Open the solution in Visual Studio.
2. Make sure the path to `b1_benchmark.exe` in `Program.cs` is correct.
3. Press `Ctrl + F5`.
4. Follow the instructions in the console.

## CPU-oriented pass

Settings:

- Resolution: 1280×720
- Quality: Low
- Ray Tracing: Off
- Frame Generation: Off
- Upscaling: Off
- VSync: Off

The goal is to reduce GPU rendering cost and make CPU
performance more influential on the benchmark result.

## GPU-oriented pass

Settings:

- Resolution: 1920×1080
- Quality: Cinematic
- Ray Tracing: On
- Frame Generation: Off
- Upscaling: Off
- VSync: Off

The goal is to increase the GPU rendering workload.

Frame Generation is disabled in both passes because generated
frames would distort the interpretation of the rendering
performance.

## Project structure

The project is intentionally implemented as a lightweight
C# console application. The benchmark executable is launched
directly using `System.Diagnostics.Process`.