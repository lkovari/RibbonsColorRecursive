using RibbonsColor.displaycolors;
using RibbonsColor.displaymodel;
using RibbonsColor.generator;
using RibbonsColor.model;
using RibbonsColor.solution;
using System.Diagnostics;
using System.Drawing;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long maxHoles = 1000000000;// 1 billion holes 
            long beginPos = 0;
            long endPos = maxHoles;
            long posCount = endPos - beginPos;
            AlgorythmKind algorythmKind = AlgorythmKind.NON_RECURSIVE;
            string algorythmName = algorythmKind == AlgorythmKind.RECURSIVE ? "Recursive" : " ";
            Console.WriteLine($"Punched out Colored Ribbons {algorythmName} Solution");
            Console.WriteLine($" (Interested range {beginPos} - {endPos})");
            Console.WriteLine();
            Stopwatch timer = new();
            IGenerateRibbons generateRibbons = new GenerateRibbons();
            Console.WriteLine($" 5 Ribbons Model Generate Started (with {maxHoles} holes).");
            timer.Start();
            List<IRibbonModel> ribbonsModel = generateRibbons.Generate(maxHoles);
            timer.Stop();
            Console.WriteLine($" 5 Ribbons Model Generate End (with {maxHoles} holes) Elapsed {timer.Elapsed}.");
            if (maxHoles <= 17)
            {
                IDisplayContent displayContent = new DisplayContent();
                displayContent.displayModel(ribbonsModel);
            }
            IColorFinder colorFinder = new ColorFinder();
            timer.Start();
            Console.WriteLine($" Detect Visible Colors of Ribbons Started.");
            List<Color> colors = colorFinder.FindColors(algorythmKind, ribbonsModel, beginPos, endPos);
            timer.Stop();
            Console.WriteLine($" Detect Visible Colors of Ribbons End, {colors.Count} Colors Detected. Elapsed {timer.Elapsed}");
            if (posCount <= 17)
            {
                IDisplayColors displayColors = new DisplayColors();
                displayColors.DisplayColorName(colors);
            }
        }
    }
}


