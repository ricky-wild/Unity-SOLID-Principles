
using System;
using System.Collections.Generic;

public class ShapeCreator : IShapeCreator
{

	private List<IShapes> listOfShapes = new List<IShapes>(); //Cached for performance.

	public ShapeCreator() {}

	public void CreateSquare(float area)
	{
		this.listOfShapes.Add(new Square(area));
	}
	public void CreateCircle(float radius)
	{

	}

	public List<IShapes> GetShapes()
	{
		return this.listOfShapes;
	}
}