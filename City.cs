using System;
using System.Collections.Generic;

namespace Planner
{
  class City
  {
    public List<Building> Collection{get;}

    private string CityName;
    private string Mayor;
    private int Year;

    public City(string CityName, string mayor, int year)
    {
      this.CityName = CityName;
      Mayor = mayor;
      Year = year;
      Collection = new List<Building>();
    }
    //this. referes to the fields and functions in the class

    public void addBuilding(Building building)
    {
      Collection.Add(building);
    }
  }
}
