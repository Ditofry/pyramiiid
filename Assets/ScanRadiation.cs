using UnityEngine;
using System.Collections;

public class ScanRadiation : MonoBehaviour {
	// Should it be the concern of the player script rather than this one 
	// to determine spawn location rather? Not sure that I like the way 
	// these concerns are seperated...
	private Transform explorerTransform;
	private Transform scanBubble;
	Bounds bounds;

	void Awake() {
		// ¯\_(ツ)_/¯
		scanBubble = this.transform;
		explorerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		// We want the sphere to expand in front of explorer with diameter 
		// flush with the camera
		scanBubble.up = explorerTransform.up;
		scanBubble.position = explorerTransform.position;
	}

	void Grow(){
		scanBubble.localScale += new Vector3(1.5F, 1.5F, 1.5F);
	}

	void Dissapate(){
		Destroy (gameObject);
	}
	
	void Update () {
		// Bubble magnitude of 300 will allow the scan to make it most of the 
		// way down the longer corridors
		if (scanBubble.localScale.magnitude < 300) {
			Grow ();
		} else Dissapate();
	}
}
