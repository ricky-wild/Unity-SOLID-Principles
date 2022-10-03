//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
using System;
using System.Collections.Generic;

public interface IShapeRenderer //: MonoBehaviour
{
	void RenderSquares(List<IShapes> shapes);

	void RenderCircles(List<IShapes> shapes);

	void SetRenderShapesFlag(bool b);

	void InitializeRenderMaterial();

	void InitializeShapesToRender();
}
