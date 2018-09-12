using System.Collections.Generic;
using System;

namespace Places.Models
{
  public class Place
  {
    private int _id;
    public string cityName { get; set; }
    public string imgURL {get; set; }
    public string lengthStayed {get; set; }
    private static List<Place> _instances = new List<Place> { };

    public Place(string newName, string newLength, string newIMG)
    {
      cityName = newName;
      imgURL = newIMG;
      lengthStayed = newLength;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public int GetId()
    {
      return _id;
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
