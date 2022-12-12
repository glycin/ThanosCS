using ThanosCS;

if (args.Length == 0)
{
    Console.WriteLine($"Thanos can't snap your code without knowing where it is... Supply the path to your projects root directory.");
    return;
}

Art.RenderThanos();

Console.WriteLine($"Ready to bring balance to {args[0]}?");

Console.Read();

Art.RenderSnap();

Thread.Sleep(1000);

var startDirectory = args[0];

TraverseDirectoryTree(startDirectory);

void TraverseDirectoryTree(string directoryPath)
{
    var filesAndDirectories = Directory.GetFileSystemEntries(directoryPath);

    foreach (var fileOrDirectory in filesAndDirectories)
    {
        if (Directory.Exists(fileOrDirectory))
        {
            TraverseDirectoryTree(fileOrDirectory);
        }
        else if (fileOrDirectory.EndsWith(".java"))
        {
            var lines = File.ReadLines(fileOrDirectory).ToArray();
            SnapLines(lines, fileOrDirectory);
            File.WriteAllLines(fileOrDirectory, lines);
        }
    }
}

void SnapLines(string[] lines, string filename)
{
    var targetAmmount = lines.Where(l => !string.IsNullOrEmpty(l) && !string.IsNullOrWhiteSpace(l)).Count() / 2;
    var snappedCount = 0;

    while(snappedCount < targetAmmount)
    {
        for(var i = 0; i < lines.Length; i++)
        {
            var random = new Random().NextDouble();
            if(random < 0.5d)
            {
                lines[i] = "";
                snappedCount++;
                Console.WriteLine($"Snapped line {i} from {Path.GetFileName(filename)}");
            }
        }
    }
}