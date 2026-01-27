using System.Collections.Generic;

public class ListManager
{
    List<int> list = new List<int>();

    public void AddElement(int item)
    {
        list.Add(item);
    }

    public void RemoveElement(int item)
    {
        list.Remove(item);
    }

    public int GetSize()
    {
        return list.Count;
    }
}
