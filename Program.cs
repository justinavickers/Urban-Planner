using System;
using System.Collections.Generic;
namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building FiveOneTwoEight = new Building("512 8th Avenue")
      {
        Width = 20,
        Depth = 10,
        Stories = 4
      };

      FiveOneTwoEight.Construct();
      FiveOneTwoEight.Purchase("Steve");



      Building SixSixSeven = new Building("667 New ST.")
      {
        Width = 23,
        Depth = 13,
        Stories = 6
      };

      SixSixSeven.Construct();
      SixSixSeven.Purchase("Jacob");

       Building NewBuilding = new Building("New Building")
      {
        Width = 12,
        Depth = 22,
        Stories = 2
      };

      NewBuilding.Construct();
      NewBuilding.Purchase("Deanna");

    City Noshville = new City("Fred", "Fred", 3207);
    Noshville.addBuilding(FiveOneTwoEight);
    Noshville.addBuilding(SixSixSeven);
    Noshville.addBuilding(NewBuilding);

    foreach (Building building in Noshville.Collection) {
     Console.WriteLine($@"
      {building.Address}
      Designed By {building.Designer}
      Constructed on {building.DateConstructed}
      Owned by {building.Owner}
      {building.Volume} meters of space
      ");
}
    }
  }
}
