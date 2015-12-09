using UnityEngine;
using System.Collections;

public class OpenJar : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float turnSpeed = 30f;
    public Camera camera;


    void Start()
    {




    }



    void Update()
    {

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            Transform objectHit = hit.transform;
            Debug.Log(hit);
            //objectHit.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            //Debug.Log(objectHit);
			if ((objectHit.name == "JackalBase") || (objectHit.name == "WomanBase") ||(objectHit.name == "BaboonHead") || (objectHit.name == "JackalHead") || (objectHit.name == "Imseti") || (objectHit.name == "Qebe") || (objectHit.name == "sarcophagusLid") || (objectHit.name == "Coffin") || (objectHit.name == "Mummy") || (objectHit.name == "OverMummy") || (objectHit.name == "Ra") || (objectHit.name == "Khnum") || (objectHit.name == "Apis") || (objectHit.name == "Bastet"))
            {
				if (Input.GetButtonDown("OpenUp"))
				{
					transform.Translate(objectHit.transform.up * moveSpeed * Time.deltaTime);
				}
				if (Input.GetButtonDown("OpenDown"))
				{
					transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
				}
				if (Input.GetButtonDown("TwistRight"))
				{
					transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
				}
				if (Input.GetButtonDown("TwistLeft"))
				{
					transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
				}
                /*if (Input.GetKey(KeyCode.I))
                    objectHit.Translate(objectHit.transform.up * moveSpeed * Time.deltaTime);
                if (Input.GetKey(KeyCode.M))
                    objectHit.Translate(-objectHit.transform.up * moveSpeed * Time.deltaTime);
                if (Input.GetKey(KeyCode.K))
                    objectHit.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
                if (Input.GetKey(KeyCode.J))
                    objectHit.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);*/
            }

            // do whatever you want
        }

        /*if (Input.GetButtonDown("OpenUp"))
            transform.Translate(objectHit.transform.up * moveSpeed * Time.deltaTime);
        if (Input.GetButtonDown("OpenDown"))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        if (Input.GetButtonDown("TwistRight"))
            transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
        if (Input.GetButtonDown("TwistLeft"))
            transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);*/




    }
}
