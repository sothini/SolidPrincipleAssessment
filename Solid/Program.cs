using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    //*
    //The below simple example demostrates the interface segregation principle 
    //Where a class is not forced to implement methods that it does not need 
    //
    //*//
    public interface IArea
    {
        decimal getArea();
    }

    public interface IPerimeter
    {
        decimal getPerimiter();
    }

    public class Rectangle : IArea, IPerimeter
    {
        public decimal getArea()
        {
            throw new NotImplementedException();
        }

        public decimal getPerimiter()
        {
            throw new NotImplementedException();
        }
    }

    public interface ICircumference
    {
        decimal getCircumference();
    }

    public class Circle : IArea, ICircumference
    {
        public decimal getArea()
        {
            throw new NotImplementedException();
        }

        public decimal getCircumference()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            var circle = new Circle();

            //common methods
            rectangle.getArea();
            circle.getArea();


            //different methods
            rectangle.getPerimiter();
            circle.getCircumference();

        }
    }
}
