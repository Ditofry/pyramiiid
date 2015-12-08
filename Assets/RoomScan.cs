using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class RoomScan : MonoBehaviour {

	// Attached AudioFiles
	public AudioClip subterraneanChamber;
	public AudioClip descendingPassage;
	public AudioClip ascendingPassage;
	public AudioClip queensRoom;
	public AudioClip kingsRoom;
	// Model for our scanner effect
	public GameObject scannerRadiation;
	bool scanned;

	// Cache GetComponent for brevity later on as well as performance
	private AudioSource source;
	
	void Awake () {	source = GetComponent<AudioSource>(); }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		scanned = CrossPlatformInputManager.GetButtonDown("Scan");
		if (scanned)
			Instantiate (scannerRadiation);
	}
	
}
