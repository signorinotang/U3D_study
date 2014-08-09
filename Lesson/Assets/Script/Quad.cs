using UnityEngine;
using System.Collections;

public class Quad : MonoBehaviour {
	protected MeshFilter m_MeshFt;
	protected Vector3[] m_vertices; 
	protected Vector2[] m_texcoord;

	void Awake() {
		
	}
	
	// Use this for initialization
	void Start () {
		//m_MeshFt = gameObject.AddComponen<MeshFilter>();
		m_MeshFt = gameObject.GetComponent<MeshFilter>();
		m_vertices = new Vector3[4];
		m_texcoord = new Vector2[4];
		int width = 200;
		int height = 200;
		m_vertices[0] = new Vector3(-100, 100, 0);
		m_vertices[1] = new Vector3(100, 100, 0);
		m_vertices[2] = new Vector3(100, -100, 0);
		m_vertices[3] = new Vector3(-100, -100, 0);
		int[] indices = {0, 1, 2, 0 , 2, 3};
		m_texcoord[0] = new Vector2(0, 1);
		m_texcoord[1] = new Vector2(1, 1);
		m_texcoord[2] = new Vector2(1, 0);
		m_texcoord[3] = new Vector2(0, 0);


		m_MeshFt.mesh.vertices = m_vertices; //vertices
		m_MeshFt.mesh.triangles = indices;	 //indices
		m_MeshFt.mesh.uv = m_texcoord;
		//m_MeshFt.mesh.normals = new Vector3[]{Vector3.forward, Vector3.forward, Vector3.forward, Vector3.forward};

		Texture2D tex = Resources.Load("4b") as Texture2D;
		if(tex) {
			gameObject.renderer.material.mainTexture = tex;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
