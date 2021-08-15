using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Pages.Models
{
    public class WheelModel
    {
        public int Width { get; set; }  
        public int Ratio { get; set; }
        public int Rim { get; set; }
        
        public int Diam()  //method returns the value of the diameter in mm
        {
            return (int)(Width * Ratio / 50 + Rim * 25.1); 
        }
    }
}
