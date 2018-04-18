using System.Collections.Generic;
using System;

namespace Tamagotchi.Models
{
  public class Tama
  /* Creating Jobs Class, which we will create instances from */
  {
    private string _name; /*Create Private string called _name*/
    private int _food;
    private int _happiness;
    private int _sleep;
    private static List<Tama> _pets = new List<Tama> {}; /*Create private list called _instances, which will be empty for now*/


    public Tama (string name, int food, int happiness, int sleep)
    {
      _name = name;
      _food = food;
      _happiness = happiness;
      _sleep = sleep;
    }
