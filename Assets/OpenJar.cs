using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpenJar : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float turnSpeed = 30f;
    public Camera camera;
    public Text artifactText;
    bool reveal_text = true;


    void Start()
    {
        //artifactText = myCanvas.GetComponent<Text>();
        //artifactText.text = "";



    }

    void revealText()
    {
        if (reveal_text == true)
            //artifactText.text = "The text has been changed";
            reveal_text = false;
        if (reveal_text == false)
            //artifactText.text = "";
            reveal_text = true;


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
            if (Input.GetKey(KeyCode.I))
                objectHit.Translate(objectHit.transform.up * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.M))
                objectHit.Translate(-objectHit.transform.up * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.K))
                objectHit.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.J))
                objectHit.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.H))
            {

                revealText();
            }

            // do whatever you want
        }

        /*if (Input.GetButtonDown("OpenUp"))
            transform.Translate(objectHit.transform.up * moveSpeed * Time.deltaTime);
        if (Input.GetButtonDown("OpenDown"))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        if (Input.GetButtonDown("TwistRight"))
            transform.Rotate(objectHit.transform.right, -turnSpeed * Time.deltaTime);
        if (Input.GetButtonDown("TwistLeft"))
            transform.Rotate(objectHit.transform.left, -turnSpeed * Time.deltaTime);*/




    }
}
