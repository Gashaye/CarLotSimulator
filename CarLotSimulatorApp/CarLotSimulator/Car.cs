using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
      
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

        

        public string IsDriveable { get; set; }

        public string MakeEngineNoise(string engine)
        {
            
            EngineNoise = engine;
            return engine;
        } 
        public string MakeHonkNoise(string honk)
        {
            HonkNoise = honk;
            return honk;
        }
    }
}
