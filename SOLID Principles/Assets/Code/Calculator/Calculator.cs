//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
using System;
using System.Collections.Generic;

public abstract class Calculator //: MonoBehaviour
{
	protected readonly double _sum;

	public Calculator()
	{

	}

	public abstract double SumCorrectly(List<IShapes> shapes);
}
