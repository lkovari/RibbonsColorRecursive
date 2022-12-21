// See https://aka.ms/new-console-template for more information
using RibbonsColor.displaycolors;
using RibbonsColor.displaymodel;
using RibbonsColor.generator;
using RibbonsColor.model;
using RibbonsColor.solution;
using System.Diagnostics;
using System.Drawing;

int maxHoles = 100000000;
Console.WriteLine("Punched out Colored Ribbons Recursive Solution");
Console.WriteLine();
Stopwatch timer = new();
IGenerateRibbons ribbonGenerator = new GenerateRibbons();
Console.WriteLine($"Ribbons Model Generate Started (with {maxHoles} holes).");
timer.Start();
List<IRibbonModel> ribbonsModel = ribbonGenerator.Generate(maxHoles);
Console.WriteLine($"Ribbons Model Generate End (with {maxHoles} holes).");
timer.Stop();
Console.WriteLine($"Elapsed During Generate Model { timer.Elapsed } .");
// IDisplayContent displayContent = new DisplayContent();
// displayContent.displayModel(ribbonsModel);
IColorFinder colorFinder = new ColorFinder();
timer.Start();
Console.WriteLine($"Detect Visible Colors of Ribbons Started.");
List<Color> colors = colorFinder.FindColors(ribbonsModel, 0, maxHoles);
Console.WriteLine($"Detect Visible Colors of Ribbons End, {colors.Count} Colors Detected.");
// IDisplayColors displayColors = new DisplayColors();
// displayColors.DisplayColorName(colors);
timer.Stop();
Console.WriteLine($"Elapsed During Detect Colors { timer.Elapsed } .");

