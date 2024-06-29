using System;
using System.IO;
using System.Net.Security;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Net.WebRequestMethods;

List<string> submods = [];
var rootPath = args[0];
int thisLevel = 0;
List<Repo> Repos = [];

var options = new EnumerationOptions
            {
                IgnoreInaccessible = true,
                RecurseSubdirectories = true
            };

foreach (string fileName in Directory.EnumerateFiles(rootPath, ".gitmodules", options))
{
  var relFilePath = Path.GetDirectoryName(fileName[rootPath.Length..]);
  if (relFilePath.Length > 1)
  {
    relFilePath += "\\";    
  }
  for (int i = Repos.Count - 1; i > -1; i--)
  {
    if (!relFilePath.StartsWith(Repos[i].Path))
    {
      continue;
    }
    thisLevel = Repos[i].Level + 1;
    break;
  }
  Repo thisRepo = new(relFilePath, thisLevel);
  Repos.Add(thisRepo);

  List<string> allLinesText = System.IO.File.ReadAllLines(fileName).ToList();
  string submodName = "";
  string submodPath = "";
  string submodURL = ""; 
  foreach (var fileline in allLinesText)
  {
    if (fileline.Contains("[submodule"))
    {
      submodName = fileline[(fileline.IndexOf("\"") + 1)..];
      submodName = submodName.TrimEnd();
      submodName = submodName.Remove(submodName.Length-2);
    }
    if (fileline.Contains("url"))
    {
      submodURL = fileline[(fileline.IndexOf("=") + 1)..];
      submodURL = submodURL.Trim();
    }
    if (fileline.Contains("path"))
    {
      submodPath = fileline[(fileline.IndexOf("=") + 1)..];
      submodPath = submodPath.Trim();
    }
    if (!string.IsNullOrEmpty(submodName) && !string.IsNullOrEmpty(submodURL) && !string.IsNullOrEmpty(submodPath)) 
    {
      var subModDetails = $"{relFilePath}{submodPath} ({submodName}  {submodURL})";
      subModDetails = subModDetails.Replace("/","\\");
      Repo thisSubRepo = new(subModDetails, thisLevel);
      Repos.Add(thisSubRepo);
      submodName = "";
      submodPath = "";
      submodURL = "";
    }
  }
}

var orderedList = Repos.OrderBy(x => x.Path).ToList();

foreach (var currRepo in orderedList)
{
  if (!(currRepo.Path.Contains("("))) {
    if (currRepo.Level == 0)
    {
      // First level, show as heading
      Console.WriteLine($"# {currRepo.Path}");
    }
    continue; 
  }
  String md = "";
  for (var i = 0; i < currRepo.Level; i++) { md += "  "; }
  if (currRepo.Path.Contains(".com"))
  {
    // Italize anything that refers to .com repo
    Console.WriteLine($"{md}- _{currRepo.Path}_");
  } else
  {
    Console.WriteLine($"{md}- {currRepo.Path}");
  }
}