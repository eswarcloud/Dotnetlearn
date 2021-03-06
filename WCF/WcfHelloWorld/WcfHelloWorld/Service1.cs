using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfHelloWorld.Data;

namespace WcfHelloWorld
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CalculatorService : ICalculatorService
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0} and I had Changed this", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Processed";
        //    }
        //    return composite;
        //}

        public int Add(int a, int b)
        {
            int c= a + b;
            using (CalculatorContext context = new CalculatorContext())
            {
                context.AdditionResults.Add(new Add() {Value1 = a, Value2 = b, Result = c});
                context.SaveChanges();
            }
            return c;
        }

        public int Square(int a)
        {
            return a*a;
        }

        public void Ping()
        {
            Console.WriteLine("Client is pinging");
        }
    }
}
