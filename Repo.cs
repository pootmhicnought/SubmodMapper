class Repo
{
  public string Path;
  public int Level;
  public List<String> Submods;

  public Repo(string path, int level)
  {
    Path = path;
    Level = level;
//    Submods = new List<String>();
  }
}
