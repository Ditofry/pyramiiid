using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowText : MonoBehaviour
{
    Text artifactText;
    bool reveal_text = true;
    public Camera camera;
    /*string a;
    string b;
    string c;*/
    string BaboonHead;
    string JackalHead;
    string Imseti;
    string Qebe;
    string sarcophagusLid;
    string Coffin;
    string Mummy;
    string OverMummy;
    string Ra;
    string Khnum;
    string Apis;
    string Bastet;


    // Use this for initialization
    void Start()
    {

        artifactText = gameObject.GetComponent<Text>();
        //artifactText = myCanvas.GetComponent<Text>();
        artifactText.text = "";
        BaboonHead = "Canopic jars housed organs removed from the bodies of mummies after death. Each jar contained one of four major organs—the lungs, the stomach, the liver, the intestines—that ancient Egyptians believed were needed in the afterlife. In addition to the aforementioned organs, the canopic jars were associated with the four compass directions. This canopic jar depicts the baboon-headed god, Hapi—representative of the north, protector of the lungs. Hapi was a son of the god, Horus, and guarded the throne of Osiris in the underworld.";
        JackalHead = "This canopic jar depicts the jackal-headed god, Duamutef, whose name means “he who adores his mother.” A son of the god, Horus, Duamutef was aligned with the north and protected the stomach.";
        Imseti = "This canopic jar depicts the god, Imseti, a son of Horus who served as patron for the direction of the south. Imseti was believed to have protected the liver in the afterlife.";
        Qebe = "This canopic jar depicts the falcon-headed god, Qebehsenuef, whose name means “he who refreshes his brothers.” As a son of the god Horus, Qebehsenuef protected the intestines in the afterlife.";
        sarcophagusLid = "The mummies of Egyptian pharaohs were placed at the center of a series of nested sarcophagi, with the outer layer typically made of alabaster. On the outside of this sarcophagus, the cartouche of Khufu is visible. The oval with the horizontal line at its end indicates that the name inside was a royal one.";
        Coffin = "The inner coffin housed the mummy of Khufu and was splendidly decorated. The earliest Egyptian coffins were little more than wood boxes, but they became more lavish (and shaped like the bodies they housed) over time.";
        Mummy = "Ancient Egyptian burial practices were famously meticulous. In order to better preserve the bodies for their journeys through the afterlife, bodies were desiccated by virtue of covering them in natron (a kind of soda ash found in saline lake beds) before major organs were removed and placed into canopic jars. The heart, believed to house the soul, was left in the body. The brain was liquefied via the insertion of a rod into the cranium and left to drain through the nostrils.";
        OverMummy = "After organ removal and dehydration of the body, mummies were wrapped in linen and coated in resin. Sacred amulets were placed in the layers of linen to ward off evil. As Pharaoh, Khufu would have received the finest embalming practices of his time. Only the wealthiest citizens of ancient Egypt could afford full mummification, canopic jars, etc.";
        Ra = "A statue of Ra, the Egyptian god of the sun who was believed to have created all life on earth by uttering the secret, primordial name of every creature now in existence.";
        Khnum = "A statue of Khnum, the third aspect of the sun god, Ra. Often depicted bearing the head of a ram, Khnum was the god of the Nile River, responsible for the annual floods which left deposits of silt and clay, thereby fertilizing arable land near the Nile. Using a great potter’s wheel, Khnum was said to have not only created the other Egyptian gods, but the bodies of human children, which he placed into their mothers’ wombs.";
        Apis = "A statue of Apis, an Egyptian god of strength and fertility in the form of a bull. Apis, one of the oldest gods of Egypt, also served as an intermediary between humans and the divine.";
        Bastet = "A statue of the cat-headed protection goddess, Bastet.  She acted as guardian for the god, Ra, and the pharaohs of Egypt. One of the most revered gods in the Egyptian pantheon, Bastet was the focus of a robust cult centered in the ancient city of Bubastis.";
        /*a = "Canopic jars housed organs removed from the bodies of mummies after death. Each jar contained one of four major organs—the lungs, the stomach, the liver, the intestines—that ancient Egyptians believed were needed in the afterlife. In addition to the aforementioned organs, the canopic jars were associated with the four compass directions.";
        b = "This canopic jar depicts the baboon-headed god, Hapi—representative of the north, protector of the lungs. Hapi was a son of the god, Horus, and guarded the throne of Osiris in the underworld.";
        c = "Ancient Egyptian burial practices were famously meticulous. In order to better preserve the bodies for their journeys through the afterlife, bodies were desiccated by virtue of covering them in natron (a kind of soda ash found in saline lake beds) before major organs were removed and placed into canopic jars. The heart, believed to house the soul, was left in the body. The brain was liquefied via the insertion of a rod into the cranium and left to drain through the nostrils.";*/
    }

    void revealText(string name)
    {
        Debug.Log(reveal_text);
        if (reveal_text)
        {
            artifactText.text = name;
            reveal_text = false;
        }

        else
        {
            artifactText.text = "";
            reveal_text = true;
        }



    }
    void Update()
    {

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        //artifactText.text = "Please Let this work";
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            Transform objectHit = hit.transform;
            //Debug.Log(objectHit.name);
            //if (Input.GetKey(KeyCode.H))
			(Input.GetButtonDown("ArtifactText"))
            {
                if (objectHit.name == "JackalHead")
                {
                    revealText(JackalHead);
                }
                if (objectHit.name == "Imseti")
                {
                    revealText(Imseti);
                }
                if (objectHit.name == "BaboonHead")
                {
                    revealText(BaboonHead);
                }
                if (objectHit.name == "Qebe")
                {
                    revealText(Qebe);
                }
                if (objectHit.name == "sarcophagusLid")
                {
                    revealText(sarcophagusLid);
                }
                if (objectHit.name == "Coffin")
                {
                    revealText(Coffin);
                }
                if (objectHit.name == "Mummy")
                {
                    revealText(Mummy);
                }
                if (objectHit.name == "OverMummy")
                {
                    revealText(OverMummy);
                }
                if (objectHit.name == "Ra")
                {
                    revealText(Ra);
                }
                if (objectHit.name == "Khnum")
                {
                    revealText(Khnum);
                }
                if (objectHit.name == "Apis")
                {
                    revealText(Apis);
                }
                if (objectHit.name == "Bastet")
                {
                    revealText(Bastet);
                }


            }

        }

    }


}
