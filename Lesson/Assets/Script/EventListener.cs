using UnityEngine;
using System.Collections;

public class EventListener : MonoBehaviour {

	public UISprite m_sprite;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick() {
		buttonClick();
		buttonClick2();
	}

	void OnPress(bool isPressed) {
		if(isPressed) {
			m_sprite.spriteName = "burlap";
			gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 1);

			//gameObject.GetComponent<UISprite>().MakePixelPerfect();
		} else {
			m_sprite.spriteName = "sand";
			gameObject.transform.localScale = new Vector3(1, 1, 1);
			//gameObject.GetComponent<UISprite>().MakePixelPerfect();
		}
	}

	void buttonClick() {
		Debug.Log("button 1");
	}

	void buttonClick2() {
		Debug.Log ("button 2");
	}

}
