﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KoszaryBool : MonoBehaviour
{
    public bool KoszaryCzy = false;
    Text CzyTrue;
    public GameObject koszaryPrefab;
    GameObject Koszaryy;
    GameObject Koszary;
    public Button Kosz;

    private void Start()
    {
        Button kosza = GetComponent<Button>();
        kosza.onClick.AddListener(OnClickKoszary);
    }
    private void Update()
    {

            //if (Input.GetMouseButtonDown(1))
            //{
            //    Koszary = Instantiate(koszaryPrefab);
            //    Koszary.active = false;
            //    Koszary.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
            //    Koszary.active = true;
            //    CzyTrue.text = "nie";
            //}
    }
    public void OnClickKoszary()
    {
        CzyTrue.text = "tak";
    }

}

    




// if (CzyTrue.text == "tak" )
        
//            if (Input.GetMouseButtonDown(1))
//          {
//                Koszary = Instantiate(koszaryPrefab);
//Koszary.act//ive = false;
//                Koszary.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
//Koszary.active = true;
//                CzyTrue.text = "nie";
//            }
//        }