using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class AdvancedMultiStreamProceduralMesh : MonoBehaviour
{

	void OnEnable()
	{
		Mesh.MeshDataArray meshDataArray = Mesh.AllocateWritableMeshData(1);

		var mesh = new Mesh
		{
			name = "Procedural Mesh"
		};
		Mesh.ApplyAndDisposeWritableMeshData(meshDataArray, mesh);
		GetComponent<MeshFilter>().mesh = mesh;
	}
}