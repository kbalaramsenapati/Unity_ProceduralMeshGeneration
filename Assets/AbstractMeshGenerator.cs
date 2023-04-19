using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter)),RequireComponent(typeof(MeshRenderer))]
public abstract class AbstractMeshGenerator : MonoBehaviour
{
	#region Decleration
	[SerializeField]
	protected Material material;

	[SerializeField]
	protected List<Vector3> vertices;
	protected List<int> triangles;

	protected int numVertices;
	protected int numTriangles;

	private MeshFilter meshFilter;
	private MeshRenderer meshRenderer;
	private MeshCollider meshCollider;
	private Mesh mesh;
	#endregion

	#region System Define Function
	private void Update()
	{
        meshFilter=GetComponent<MeshFilter>();
		meshRenderer=GetComponent<MeshRenderer>();
		meshCollider=GetComponent<MeshCollider>();

		meshRenderer.material=material;


    }
    #endregion

    #region User Define Function
    protected abstract void SetMeshNums();

	private void InitMesh()
	{
		vertices=new List<Vector3>();
		triangles=new List<int>();
	}
	private bool IsValidMesh()
	{
		return true;
	}
	private void CreateMesh()
	{
		mesh=new Mesh();

        SetVertices();
        SetTriangles();

		if(IsValidMesh())
		{
			mesh.SetVertices(vertices);
			mesh.SetTriangles(triangles, 0);


		}
    }


    protected abstract void SetVertices();
    protected abstract void SetTriangles();
    #endregion
}
