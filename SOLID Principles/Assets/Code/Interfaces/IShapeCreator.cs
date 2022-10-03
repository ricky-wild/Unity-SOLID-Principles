using System;
using System.Collections.Generic;

public interface IShapeCreator //: MonoBehaviour
{
	void CreateSquare(float area);
	void CreateCircle(float radius);

	List<IShapes> GetShapes();
}