using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeApiDemo.obj;

public class Item {
    public string name {get; set;}
    public int score {get; set;}
    public int rank {get; set;}
    public Item() {}
    public Item(int id, string name, string description, int rarity, int carryLimit, int value) {
   
    }

}