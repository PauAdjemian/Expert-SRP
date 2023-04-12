using System;
using System.Collections;
using System.Text;
namespace SRP;
public class Shelve
{
    private ArrayList ShelveItems = new ArrayList();
    public string shelve { get ; set; }
    
    public Shelve(String shelve)
    {
        this.shelve=shelve;
    }
    public void AddBook(Book item)
    {
        this.ShelveItems.Add(item);
    }
    public void RemoveBook(Book item, String shelve)
    {
        this.ShelveItems.Remove(item);
    }
}

