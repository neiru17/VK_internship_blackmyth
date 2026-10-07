using System.Diagnostics;

const string benchmarkPath =
    @"C:///";

Console.WriteLine("========================================");
Console.WriteLine(" Black Myth: Wukong Benchmark Automation");
Console.WriteLine("========================================");
Console.WriteLine();

Console.WriteLine("PC:");
Console.WriteLine("CPU: Intel Core i5-12400F");
Console.WriteLine("GPU: NVIDIA RTX 3060");
Console.WriteLine("RAM: 16 GB");
Console.WriteLine();

Console.WriteLine("========================================");
Console.WriteLine("CPU-ORIENTED PASS");
Console.WriteLine("========================================");

Console.WriteLine("Resolution: 1280x720");
Console.WriteLine("Quality: Low");
Console.WriteLine("Ray Tracing: OFF");
Console.WriteLine("Frame Generation: OFF");
Console.WriteLine("Upscaling: OFF");
Console.WriteLine("VSync: OFF");
Console.WriteLine();

Console.WriteLine("Press ENTER to start benchmark...");
Console.ReadLine();

StartBenchmark(benchmarkPath);

Console.WriteLine();
Console.WriteLine("Benchmark started.");
Console.WriteLine("Complete the benchmark and press ENTER.");
Console.ReadLine();

Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine("GPU-ORIENTED PASS");
Console.WriteLine("========================================");

Console.WriteLine("Resolution: 1920x1080");
Console.WriteLine("Quality: Cinematic");
Console.WriteLine("Ray Tracing: ON");
Console.WriteLine("Frame Generation: OFF");
Console.WriteLine("Upscaling: OFF");
Console.WriteLine("VSync: OFF");
Console.WriteLine();

Console.WriteLine("Press ENTER to start benchmark...");
Console.ReadLine();

StartBenchmark(benchmarkPath);

Console.WriteLine();
Console.WriteLine("Benchmark started.");
Console.WriteLine("Complete the benchmark and press ENTER.");
Console.ReadLine();

Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine("Benchmark completed");
Console.WriteLine("========================================");

static void StartBenchmark(string path)
{
    if (!File.Exists(path))
    {
        Console.WriteLine("ERROR: Benchmark Tool not found.");
        Console.WriteLine(path);
        return;
    }

    Process.Start(new ProcessStartInfo
    {
        FileName = path,
        UseShellExecute = true
    });
}