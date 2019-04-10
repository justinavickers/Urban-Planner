using System;
using System.Collections.Generic;

namespace Planner
{
  class Building {

      private string _designer = "Justina";

      private DateTime _dateConstructed = DateTime.Now;

      private string _address;

      private string _owner;

      public int Stories {get; set;}

      public double Width {get; set;}

      public double Depth {get; set;}
      //getters and setters also known as accessors and mutators

      public double Volume {
        get {
          return  Width * Depth * (3 * Stories);
        }
      }

      public Building(string address) {
        _address = address;
      }

      public void Construct() {
        _dateConstructed = DateTime.Now;
        // return this;
        //will allow us to chain methods
      }
      public void Purchase(string steve) {
        _owner = steve;
        // return this;
        //taking out void on public void and replacing it with return this allows us to chain these methods
      }

      public DateTime DateConstructed {
        get {
          return  _dateConstructed;
        }
      }

      public string Address {
        get {
          return _address;
        }
      }

      public string Designer {
        get {
          return _designer;
        }
      }

      public string Owner {
        get {
          return _owner;
        }
      }
  }


}