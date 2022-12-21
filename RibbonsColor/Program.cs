// See https://aka.ms/new-console-template for more information
using RibbonsColor.displaycolors;
using RibbonsColor.displaymodel;
using RibbonsColor.generator;
using RibbonsColor.model;
using RibbonsColor.solution;
using System.Diagnostics;
using System.Drawing;

int maxHoles = 100000000;
Console.WriteLine("Colored Ribbons Solution");
Stopwatch timer = new Stopwatch();
IGenerateRibbons ribbonGenerator = new GenerateRibbons();
List<IRibbonModel> ribbonsModel = ribbonGenerator.Generate(maxHoles);
// IDisplayContent displayContent = new DisplayContent();
// displayContent.displayModel(ribbonsModel);
IColorFinder colorFinder = new ColorFinder();
timer.Start();
List<Color> colors = colorFinder.FindColors(ribbonsModel, 0, maxHoles);
// IDisplayColors displayColors = new DisplayColors();
// displayColors.DisplayColorName(colors);
timer.Stop();
Console.WriteLine($"Elapsed { timer.Elapsed.ToString() } .");
 
