using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; set; }
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      /*
      0
      index: 0 id: 1
      index: 1 id: 2
      */
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void RemoveById(int id)
    {
      /*
      index: 0 id: 
      */

      //count: 3
      _instances.RemoveAt(id - 1);
      //count: 2

      //remove id 2
      //Count: 3
      //index: 
      //index: 
      //start at the next item, subtract one from each id in the list 

      // for (int index = id - 1; index < _instances.Count - 1; index++)
      // {
      //   _instances[index].Id = _instances[index].Id - 1;
      // }

      //Count: was 4, now 3
      //index: 0 set to id:1
      //index: 1 set to id:2
      //index: 2 set to id:3

      for (int index = 0; index < _instances.Count; index++)
      {
        _instances[index].Id = index + 1;
      }
    }

  }
}