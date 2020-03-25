using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBudynki : MonoBehaviour
{
    public GameObject domPrefab;
    public GameObject koszaryPrefab;
    public GameObject bibliotekaPrefab;
    bool czyWcisnieteBudynki = false;
    Text Kosz;
    Button koszaryBTN;

    private void Start()
    {
        GameObject Koszary = GameObject.Find("Koszary");
    }
    

}
