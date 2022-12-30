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
            const byte RIBBONS_COUNT = 5;
            const byte DISPLAY_MODEL_LIMIT = 40;
            long maxHoles = 2000000000;// 1 billion holes 
            long beginPos = 0;
            long endPos = maxHoles;
            long posCount = endPos - beginPos;
            AlgorythmKind algorythmKind = AlgorythmKind.RECURSIVE;
            string algorythmName = algorythmKind == AlgorythmKind.RECURSIVE ? "Recursive" : "";
            Console.WriteLine($"Punched out Colored Ribbons Solution {algorythmName}");
            Console.WriteLine($" (Interested range {beginPos} - {endPos:#,#)})");
            Console.WriteLine();
            Stopwatch timer = new();
            IGenerateRibbons generateRibbons = new GenerateRibbons();
            timer.Start();
            List<IRibbonModel> ribbonsModel = generateRibbons.Generate(maxHoles, RIBBONS_COUNT);
            timer.Stop();
            Console.WriteLine($" { RIBBONS_COUNT } Ribbons Model Generated (with {maxHoles:#,#} holes) Elapsed Time is {timer.Elapsed}.");
            if (maxHoles <= DISPLAY_MODEL_LIMIT)
            {
                IDisplayContent displayContent = new DisplayContent();
                displayContent.displayModel(ribbonsModel);
            }
            IColorFinder colorFinder = new ColorFinder();
            timer.Start();
            Console.WriteLine();
            List<KnownColor> colors = colorFinder.FindColors(algorythmKind, ribbonsModel, beginPos, endPos);
            timer.Stop();
            Console.WriteLine($" Detected Visible Colors of Ribbons: {colors.Count:#,#} Elapsed Time is {timer.Elapsed}");
            if (posCount <= DISPLAY_MODEL_LIMIT)
            {
                IDisplayColors displayColors = new DisplayColors();
                displayColors.DisplayColorName(colors);
            }
        }
    }
}


