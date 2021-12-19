using System.Text.RegularExpressions;
using MachineFileSanitizer;

const string inputPath = @"C:\Users\kustn.DIRTBOX\OneDrive\ClientFiles\Desert Diamond - West Valley\SourceProcessDocumentation\Go Live - Import\pristine\Slots Master Slot Trak.csv";
const string outputPath = @"C:\Users\kustn.DIRTBOX\OneDrive\ClientFiles\Desert Diamond - West Valley\SourceProcessDocumentation\Go Live - Import\pristine\Slots Master Slot Trak.sanitized.csv";
Regex surroundedByQuotes = new Regex(@"(""[^""]+"")", RegexOptions.Singleline | RegexOptions.Compiled);

// See https://aka.ms/new-console-template for more information

var input = (await File.ReadAllLinesAsync(inputPath)).ToList();
using var writer = new System.IO.StreamWriter(outputPath);
foreach (var line in input)
{
    await writer.WriteLineAsync(surroundedByQuotes.Replace(line, match => match.Value.SwitchCommas()));
}

Console.ReadKey();