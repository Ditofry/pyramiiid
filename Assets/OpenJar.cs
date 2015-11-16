using UnityEngine;
using System.Collections;

public class OpenJar : MonoBehaviour {
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
	void Start () {
      
	
	}
	
	void Update () {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
      
    }
}
