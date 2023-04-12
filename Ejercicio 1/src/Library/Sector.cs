using System;
using System.Collections;
using System.Text;
namespace SRP;

public class Sector
{   
    public string sector { get ; set; }
    public ArrayList SectorItems = new ArrayList();

    public Sector(String sector)
    {
        this.sector=sector;
    }
    public void AddShelve(Shelve item)
    {
        this.SectorItems.Add(item);
    }
}
