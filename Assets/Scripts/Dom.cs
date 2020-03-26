using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Dom : MonoBehaviour
{
    public bool DomCzy = false;
    public GameObject DomPrefab;
    Text liczbaLudnosci;
    GameObject DomP;
    int numerDomu = 1;
    public List<GameObject> listDomow = new List<GameObject>();

    private void Start()
    {

        DomPrefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefab/Dom.prefab", typeof(GameObject));
        Button domek = GetComponent<Button>();
        domek.onClick.AddListener(OnClickDom);
        liczbaLudnosci = GameObject.Find("Ludnosc").GetComponent<Text>();
    }
    private void Update()
    {
        if (DomCzy == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                DomP = Instantiate(DomPrefab);
                DomP.name = "Dom" + numerDomu;
                numerDomu++;
                listDomow.Add(DomP);
                DomP.SetActive(false);
                DomP.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
                DomP.SetActive(true);
                DomCzy = false;
            }
        }
        liczbaLudnosci.text = "Liczba Domow:"+listDomow.Count.ToString();

    }
    public void OnClickDom()
    {
        DomCzy = true;
    }
}
