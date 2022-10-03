//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

public class Cube : IShapes, I3DShapes //: MonoBehaviour
{
	private double volume;

	public Cube(double volume)
	{
		this.volume = volume;
	}

	public double Area()
	{
		return 0;
	}

	public double Volume()
	{
		return this.volume;
	}
}
