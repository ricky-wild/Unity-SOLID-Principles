using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeRenderer : MonoBehaviour, IShapeRenderer 
{

    //private ShapeCreator shapeCreator = new ShapeCreator(); //Concrete - needs to be abstract
    private IShapeCreator shapeCreator = new ShapeCreator();
    private bool renderShapesFlag;
    private Material material;

	private void Awake() //Called once, if gameobject is active in scene.
	{
        this.renderShapesFlag = true; //Circle circle = new Circle(1.0f);         
    }

    void Start() //Called once, on frame enabled before Update() but after Awake().
    {
        InitializeRenderMaterial();
        InitializeShapesToRender();

    } 

    public void InitializeRenderMaterial()
	{
        Shader shader = Shader.Find("Hidden/Internal-Colored");
        this.material = new Material(shader);
        this.material.hideFlags = HideFlags.HideAndDontSave;

        //Turn on alpha blending
        this.material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        this.material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);

        //Turn backface culling off
        this.material.SetInt("_Cull", (int)UnityEngine.Rendering.CullMode.Off);

        //Turn off depth writes
        this.material.SetInt("_ZWrite", 0);
    }

    public void InitializeShapesToRender()
	{
        int maxSquares = 6;
        float area = 0.25f;
        int multiplier = 2;
        for (int i = 0; i < maxSquares; i++)
        {
            this.shapeCreator.CreateSquare(area);
            area = area * multiplier;
        }
    }

    public void RenderSquares(List<IShapes> shapes)
    {
		float x = 1f;
		float y = 0f;
		for (int i = 0; i < shapes.Count; i++)
		{
			IShapes shape = shapes[i];

			if (shape.GetType() == typeof(Square))
			{
				Square square = (Square)shape;
				float w = (float)square.GetWidth();
				float h = (float)square.GetHeight();

                x = x + w;

				this.material.SetPass(0);

				GL.Begin(GL.QUADS);
				GL.Color(Color.white);
				GL.Vertex3(x  , y,   0);
				GL.Vertex3(x+w, y,   0);
				GL.Vertex3(x+w, y+h, 0);
				GL.Vertex3(x  , y+h, 0);
				GL.End();
			}

		}
	}

    public void RenderCircles(List<IShapes> shapes)
    {

        for (int i = 0; i < shapes.Count; i++)
        {
            IShapes shape = shapes[i];

            if (shape.GetType() == typeof(Circle))
            {

            }

        }
    }

    public void SetRenderShapesFlag(bool b)
	{
        this.renderShapesFlag = b;
	}

	public void OnPostRender() //Unity render - script must be placed on camera obj
	{
        if (this.renderShapesFlag)
        {
            RenderSquares(this.shapeCreator.GetShapes());
            //RenderCircles();
            //this.renderShapesFlag = false;
        }
    }

	void Update() //Unity while loop.
    {
    }

    private void RenderShapesIncorrectly(List<object> shapes)
    {
        double sum = 0;
        for (int i = 0; i < shapes.Count; i++)
        {
            object shape = shapes[i].GetType();

            //if (shape.GetType() == typeof(Circle))
            if (shape is Circle circle)
            {
                //Do something.
                double radius = circle.GetRadius();
                double area = Math.PI * (radius * radius);
                sum += area;
            }
            if (shape.GetType() == typeof(Square))
            {
                //Do something.
            }
            if (shape.GetType() == typeof(Triangle))
            {
                //Do something.
            }
            //if (shape.GetType() == typeof(Rhombicosidodecahedron)){}
            //ALL OF THESE IF STATEMENTS ARE OPEN TO MODIFICATION, WITH EACH TIME
            //WE ADD ANOTHER, WE'RE BREAKING THE OPEN CLOSED PRINCIPLE.
        }
    }
}
