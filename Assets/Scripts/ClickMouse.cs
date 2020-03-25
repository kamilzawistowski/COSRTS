using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickMouse : MonoBehaviour
{
    public Text Text2;
    public GameObject currentObject;
    public Text Text3;
    public Text DrewnoJ;
    public Text KamienJ;
    public Text ZlotoJ;
    public GameObject BazaJ;
    public int IloscDrewno;
    public int IloscKamien;
    public int IloscZloto;
    bool drewnoJeden = false;
    public List<GameObject> ListaObiektow = new List<GameObject>();

    Baza ListaChlopow = new Baza();
    

    private void Start()
    {
        //GameObject ButtonBazaa = GameObject.Find("NazwaTla");
        GameObject InfoLeft = GameObject.Find("InfoLeft");
        Text2 = InfoLeft.GetComponent<Text>();
        GameObject Drewno = GameObject.Find("DrewnoT");
        DrewnoJ = Drewno.GetComponent<Text>();
        GameObject Kamien = GameObject.Find("KamienT");
        KamienJ = Kamien.GetComponent<Text>();
        GameObject Zloto = GameObject.Find("ZlotoT");
        ZlotoJ = Zloto.GetComponent<Text>();
        GameObject Textx2 = GameObject.Find("InfoRight");
        Text3 = Textx2.GetComponent<Text>();
        Text2.text = "";
        Text3.text = "";
       
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                currentObject = hit.collider.gameObject;
                Text2.text = hit.collider.gameObject.name; //Do usuniecia
                
            }
            else if(hit.collider != gameObject)
            {
                currentObject = null;
               Text2.text = "Tlo"; // DO usuniecia
            }

            GameObject ChlopekTest = GameObject.Find("Chlopek");
            GameObject DrewnoJedenMiesjce = GameObject.Find("DMiejsceJeden");

            if (Text2.text == "Chlopek" && Text3.text == "Drewno")
            {
                {
                    //GameObject Textx2 = GameObject.Find(Text2.text);
                    //GameObject DrewnoJedenMiesjce = GameObject.Find("DMiejsceJeden");
                    ChlopekTest.transform.position = DrewnoJedenMiesjce.transform.position;
                }
            }

            if (ChlopekTest.transform.position.x == DrewnoJedenMiesjce.transform.position.x && ChlopekTest.transform.position.y == DrewnoJedenMiesjce.transform.position.y)
            {
                IloscDrewno++;
                DrewnoJ.text = "Drewno: " + IloscDrewno.ToString();
            }


            if (Text2.text == "Chlopek" && Text3.text == "Kamien")
            {
                {
                    IloscKamien++;
                    //GameObject Textx2 = GameObject.Find(Text2.text);
                    GameObject KamienJedenMiesjce = GameObject.Find("KMiejsceJeden");
                    ChlopekTest.transform.position = KamienJedenMiesjce.transform.position;
                    KamienJ.text = "Kamien: " + IloscKamien.ToString();
                }
            }
            if (Text2.text == "Chlopek" && Text3.text == "Zloto")
            {
                {
                    IloscZloto++;
                    //GameObject Textx2 = GameObject.Find(Text2.text);
                    GameObject ZlotoJedenMiesjce = GameObject.Find("ZMiejsceJeden");
                    ChlopekTest.transform.position = ZlotoJedenMiesjce.transform.position;
                    ZlotoJ.text = "Zloto: " + IloscZloto.ToString();
                }
            }
            if (Text2.text == "Chlopek" && Text3.text == "Baza")
            {
                {
                    //GameObject Textx2 = GameObject.Find(Text2.text);
                    //GameObject DrewnoJedenMiesjce = GameObject.Find("BMiejsceJeden");
                    ChlopekTest.transform.position = DrewnoJedenMiesjce.transform.position;
                }
            }
        }

       


        if (Input.GetMouseButtonDown(1))
        {

            RaycastHit2D hit2 = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if (hit2.collider != null)
            {
                Text3.text = hit2.collider.gameObject.name;
            }
            else if (hit2.collider != gameObject)
            {
                Text3.text = "Tlo";
            }

            if 
            (Text2.text == "")
            {

            }
            else if (Text2.text == "Chlopek")
            {
                Vector3 mousePos2D = Input.mousePosition;
                mousePos2D.z = -Camera.main.transform.position.z - 10;
                Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
                GameObject chlopek = GameObject.Find(Text2.text);
                chlopek.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
            }
            else if (Text2.text == "Chlopek2")
            {
                Vector3 mousePos2D = Input.mousePosition;
                mousePos2D.z = -Camera.main.transform.position.z - 10;
                Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
                GameObject chlopek = GameObject.Find(Text2.text);
                chlopek.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
            }
        }
    }
}

        
        


            



