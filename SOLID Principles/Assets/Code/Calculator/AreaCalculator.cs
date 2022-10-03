//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
using System;
using System.Collections.Generic;

public class AreaCalculator : IAreaCalculator //Calculator//: MonoBehaviour
{

    //private int _sum;

    public AreaCalculator() { }

    //public override double SumCorrectly(List<IShapes> shapes)
    public double SumCorrectly(List<IShapes> shapes)
    {
        double sum = 0;
        for (int i = 0; i < shapes.Count; i++)
        {
            //IShapes shape = shapes[i];
            sum += shapes[i].Area();//shape.Area();
        }
        return sum;
    }




    //private double SumIncorrectly(List<object> shapes)
    //{
    //    //Breaking Open Closed Principle.
    //    //This is due to open to modification here. Instead of means by extention
    //    //we are adding/modifying the method everytime we want to support another shape.

    //    double sum = 0;
    //    for (int i = 0; i < shapes.Count; i++)
    //    {
    //        object shape = shapes[i].GetType();

    //        //if (shape.GetType() == typeof(Circle))
    //        if (shape is Circle circle)
    //        {
    //            //Do something.
    //            double radius = circle.GetRadius();
    //            double area = Math.PI * (radius * radius);
    //            sum += area;
    //        }
    //        if (shape.GetType() == typeof(Square))
    //        {
    //            //Do something.
    //        }
    //        if (shape.GetType() == typeof(Triangle))
    //        {
    //            //Do something.
    //        }
    //        //if (shape.GetType() == typeof(Rhombicosidodecahedron)){}
            
    //    }
    //    return sum;
    //}
}
