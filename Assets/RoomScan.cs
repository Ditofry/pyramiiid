using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class RoomScan : MonoBehaviour {
	
	// Attached AudioFiles
	public AudioClip subterraneanChamber;
	public AudioClip descendingPassage;
	public AudioClip ascendingPassage;
	public AudioClip queensRoom;
	public AudioClip grandGallery;
	public AudioClip kingsRoom;
	public AudioClip scanBlip;
	// Model for our scanner effect
	public GameObject scannerRadiation;
	bool scanned;
	
	// Cache GetComponent for brevity later on as well as performance
	private AudioSource audio;
	
	void Awake () {	audio = GetComponent<AudioSource>(); }
	
	void Scan () {
		// Play this one no matter what
		if (scanBlip)
			audio.PlayOneShot (scanBlip);
		// This is kind of lame, but time is of the essence and it works
		// well with our little sim
		float pos = this.transform.position.y;
		if (pos <= 3.4f) {
			audio.PlayOneShot (subterraneanChamber, 0.7F);
		} else if (pos <= 68.4f) {
			audio.PlayOneShot (descendingPassage, 0.7F);
		} else if (pos <= 91f) {
			audio.PlayOneShot (ascendingPassage, 0.7F);
		} else if (pos <= 97f) {
			audio.PlayOneShot (queensRoom, 0.7F);
		} else if (pos <= 130) {
			audio.PlayOneShot (grandGallery, 0.7F);
		} else {
			audio.PlayOneShot (kingsRoom, 0.7F);
		}
	}
	
	// Update is called once per frame
	void Update () {
		scanned = CrossPlatformInputManager.GetButtonDown("Scan");
		if (scanned) {
			Scan ();
			Instantiate (scannerRadiation);
		}
	}
	
}
