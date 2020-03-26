using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Koszary : MonoBehaviour
{
    public GameObject Koszary1;
    public GameObject Koszary2;
    public GameObject Koszary3;
    public GameObject lucznikPrefab;
    public GameObject wlocznikPrefab;
    Transform respawnPoint;
    int i = 0;
    Text Text2;
    bool czyWylaczycMenu;
    float x = 0;
    float y = 0;
    float x2 = 0;
    float y2 = 0;
    int numerLucznika = 1;
    int numerWlocznika = 1;

    public List<GameObject> ListaLucznikow= new List<GameObject>();
    public List<GameObject> ListaWlocznikow = new List<GameObject>();

    private void Awake()
    {
        

        
            Koszary1 = GameObject.Find("Wlocznik");
            Button Abc = Koszary1.GetComponent<Button>();

            Koszary2 = GameObject.Find("Lucznik");
            Button Abcd = Koszary2.GetComponent<Button>();

            Koszary3 = GameObject.Find("Exit");
            Button Abcde = Koszary3.GetComponent<Button>();

            Abc.onClick.AddListener(() => OnClickWlocznik());
            Abcd.onClick.AddListener(() => OnClickLucznik());
            Abcde.onClick.AddListener(() => WylaczMenu());

        lucznikPrefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefab/Lucznik.prefab", typeof(GameObject));
        wlocznikPrefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefab/Wlocznik.prefab", typeof(GameObject));
    }

    void Start()
    {


       
    }

    private void Update()
    {
        WlaczButton();
    }





    void WlaczButton()
    {
        GameObject Textx = GameObject.Find("InfoLeft");
        Text2 = Textx.GetComponent<Text>();

        if (Text2.text == "Koszary(Clone)")
        {
            Koszary1.SetActive(true);
            Koszary2.SetActive(true);
            Koszary3.SetActive(true);

        }
        else if (czyWylaczycMenu == true)
        {
            Koszary1.SetActive(false);
            Koszary2.SetActive(false);
            Koszary3.SetActive(false);
            czyWylaczycMenu = false;
        }
    }
    void WylaczMenu()
    {
        czyWylaczycMenu = true;
    }

    void OnClickLucznik()
    {
        if (x == 20) { y -= 2.5f; x = 0; }

        x += 4f;
        GameObject lucznik = Instantiate(lucznikPrefab);
        lucznik.name = "lucznik" + numerLucznika.ToString();
        numerLucznika++;
        ListaLucznikow.Add(lucznik);
        lucznik.active = false;
        lucznik.transform.position = this.transform.position + new Vector3(x, y, 0);
        lucznik.active = true;
    }
    void OnClickWlocznik()
    {
        if (x == 20) { y -= 2.5f; x = 0; }

        x += 4f;
        GameObject wlocznik = Instantiate(wlocznikPrefab);
        wlocznik.name = "wlocznik" + numerWlocznika.ToString();
        numerWlocznika++;
        ListaWlocznikow.Add(wlocznik);
        wlocznik.active = false;
        wlocznik.transform.position = this.transform.position + new Vector3(x, y, 0);
        wlocznik.active = true;
    }


}
