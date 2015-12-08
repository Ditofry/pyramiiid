using UnityEngine;
using System.Collections;

public class ScanRadiation : MonoBehaviour {

	// Should it be the concern of the player script to determine spawn location?
	private Transform explorerTransform;
	private Transform scanBubble;
	Bounds bounds;

	void Awake() {
		// ¯\_(ツ)_/¯
		scanBubble = this.transform;
		explorerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		// We want the sphere to expand in front of explorer
		scanBubble.up = explorerTransform.up;
		scanBubble.position = explorerTransform.position;
	}

	void Grow(){
		scanBubble.localScale += new Vector3(1.5F, 1.5F, 1.5F);
	}

	void Dissapate(){
		Destroy (gameObject);
	}

	// Update is called once per frame
	void Update () {
		if (scanBubble.localScale.magnitude < 100) {
			Grow ();
		} else Dissapate();
	}
}
