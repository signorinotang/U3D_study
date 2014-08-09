using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Texture2D tex = Resources.Load("4b") as Texture2D;
		gameObject.renderer.material.mainTexture = tex;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
  