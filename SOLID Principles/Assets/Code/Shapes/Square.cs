//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

public class Square : IShapes //: MonoBehaviour
{


    //SINGLE RESPONSIBILITY
    //The square has an area. We will need to know about it's area. 

    private double area;
    private double width;
    private double height;

    public Square(double area)
    {
        this.area = area;
        this.width = area / 2;
        this.height = area / 2;
        //Calculator areaCalculator = new AreaCalculator();
    }

    public double GetWidth()
	{
        return this.width;
	}

    public double GetHeight()
	{
        return this.height;
	}

    public double Area()
    {
        return this.area; //GetRadius();
    }

}
