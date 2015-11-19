using UnityEngine;
using System.Collections;

public class OpenJar : MonoBehaviour {
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    //RaycastHit myhit = new RaycastHit();
    //Ray myray = new Ray();

	void Start () {
      
	
	}
	
	void Update () {

        /*myray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(myray, out myhit, 1000.0f) && Input.GetMouseButtonDown(0))
            StartCoroutine("moveJar");*/
        if (Input.GetKey(KeyCode.I))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.M))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.K))
            transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.J))
            transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
         
                    
       
      
    }
    /*void moveJar()
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
}
