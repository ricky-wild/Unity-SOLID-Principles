//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

public class Circle : IShapes //: MonoBehaviour
{

    //Radius formula
    //radius = diameter / 2
    //radius = circumference / (2 * PI)
    //radius = sq rt of (area / PI)


    //SINGLE RESPONSIBILITY
    //The circle has a radius. We will need to know about it's radius. 

    private double radius;

    public Circle(double radius)
	{
        this.radius = radius;
	}

    public double GetRadius()
	{
        return this.radius;
    }

    public double Area()
	{
        return this.radius; //GetRadius();
	}



}
