using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaObjectLibrary
{
    enum Status
    {
        Not_Watching=0,
        Planning_To_Watch=1,
        Watching=2,
        Completed=3,
        Dropped=4
    }

    enum Genre
    {
        NA=0,
        Action=1,
        Adventure=2,
        Animation=3,
        Biography=4,
        Comedy=5,
        Crime=6,
        Documentary=7,
        Drama=8,
        History=9,
        Family=10,
        Fantasy=11,
        Film_Noir=12,
        Horror=13,
        Music=14,
        Musical=15,
        Mystery=16,
        Romance=17,
        Sci_Fi=18,
        Sport=19,
        Thriller=20,
        War=21,
        Western=22,
        Other=23
       
    }

    enum Type
    {
        Movie = 0,
        Tv_Show = 1
    }
}
