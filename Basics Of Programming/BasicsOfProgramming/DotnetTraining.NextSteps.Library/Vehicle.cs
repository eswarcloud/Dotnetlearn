using DotnetTraining.NextSteps.Library.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraining.NextSteps.Library
{
    /// <summary>
    /// This class contains methods for Vehicle
    /// </summary>
    public class Vehicle
    {
        //compostions
        protected IEngine engine;

        public Vehicle(string engineType)
        {
            this.engineType = engineType;
        }

        public void SetEngine(IEngine engine)
        {
            this.engine = engine;
        }

        /// <summary>
        /// This method contains method to commute
        /// </summary>
        public void Commute()
        {
            Console.WriteLine("Commuting in Vehicle");
        }

        public virtual void AdvancedCommute()
        {
            Console.WriteLine("Adv Commuting in Vehicle");
        }

        public int WheelCount { set; get; }

        protected string engineType;


    }
}
