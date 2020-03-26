using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiczbaLudnosc : MonoBehaviour
{
    Text liczbaLudnosci;
    Dom liczbaDomow = new Dom();
    int a;
    void Start()
    {
        a = liczbaDomow.listDomow.Count;
        liczbaLudnosci = this.GetComponent<Text>();
        liczbaLudnosci.text = a.ToString();
    }

    void Update()
    {
        a = liczbaDomow.listDomow.Count;
        liczbaLudnosci.text = a.ToString();
    }
}
