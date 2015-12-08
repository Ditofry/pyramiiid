using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowText : MonoBehaviour {
    //public Text artifactText;
    //bool reveal_text = false;
    //public float moveSpeed = 1f;
    public GameObject myGO;
    

	// Use this for initialization
	void Start () {

        myGO = new GameObject();
        myGO.name = "TestCanvas";
        myGO.AddComponent<Canvas>();
        Canvas myCanvas = myGO.GetComponent<Canvas>();
        myCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        myGO.AddComponent<Text>();
        Text textComponent = myGO.GetComponent<Text>();
        //Material newMaterialRef = Resources.Load<Material>("3DTextCoolVetica");
        //Font myFont = Resources.Load<Font>("coolvetica rg");

        //textComponent.font = myFont;
        //textComponent.material = newMaterialRef;
        textComponent.text = "Hello World";
        //myGO.AddComponent<Slider>();
      
        //artifactText = gameObject.GetComponent<Text>;
        //artifactText.text = "new text";
	
	}

    void OnTriggerEnter(Collider other)
    {
        //reveal_text = true;
        //revealText();
    }
    void revealText()
    {
        /*if (reveal_text == true)
             artifactText.text = "This is a hawk's head";*/
    }
    /*void makemoveable()
    {
        if (Input.GetKey(KeyCode.I))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.M))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.K))
            transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.J))
            transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
    }*/

    /*void OnTriggerExit(Collider other)
    {

    }*/

    void OnCollisionEnter()
    {
        //Destroy(gameObject);
        //artifactText.text = "This is a hawk's head";
        //gameObject.GetComponent<Animation>().Play("Levitate",  PlayMode.StopAll);
    }
	
	// Update is called once per frame
	void Update () {

    }
	
	
}
