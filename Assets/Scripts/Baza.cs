using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Baza : MonoBehaviour
{
    
    public GameObject kupChlop;
    public GameObject Baza3;
    public GameObject chlopPrefab;
    public GameObject respawnPoint;
    Text SelectedObjectTxt;
    bool czyWylaczycMenu;
    float horizontalPosChlop = 0;
    float verticalPosChlop = 0;
    int numerChlopa = 1;

    public List<GameObject> ListaChlopow = new List<GameObject>();


    void Start()
    {
        

        kupChlop = GameObject.Find("RekrutujChlop");
        Button RekrutujChlop = kupChlop.GetComponent<Button>();

        Baza3 = GameObject.Find("ExitBaza");
        Button ExitBaza = Baza3.GetComponent<Button>();

        kupChlop.SetActive(false);
        Baza3.SetActive(false);

        ExitBaza.onClick.AddListener(() => WylaczMenu());
        RekrutujChlop.onClick.AddListener(() => OnClickChlop());

    }
    void Update()
    {
        WlaczButton();
        OnChlopSelectingChlop();
    }



    void OnChlopSelectingChlop()
    {
        if (ListaChlopow.Count > 0)
        {
            foreach (var item in ListaChlopow)
            {
                if (item.name == SelectedObjectTxt.text)
                {
                    item.GetComponent<ChlopInfo>().selectedChlop = true;

                }
                else if (item.name != SelectedObjectTxt.text)
                {
                    item.GetComponent<ChlopInfo>().selectedChlop = false;
                }
            }
        }
    }

    void WlaczButton()
    {
        GameObject InfoLeft = GameObject.Find("InfoLeft");
        SelectedObjectTxt = InfoLeft.GetComponent<Text>();

        if(SelectedObjectTxt.text == "Baza")
        {
            kupChlop.SetActive(true);
            Baza3.SetActive(true);
        }
        else if(czyWylaczycMenu == true)
        {
            kupChlop.SetActive(false);
            Baza3.SetActive(false);
            czyWylaczycMenu = false;
        }
    }

    void WylaczMenu()
    {
        czyWylaczycMenu = true;
    }

    void OnClickChlop()
    {
        if (horizontalPosChlop == 15) { verticalPosChlop -= 2.5f; horizontalPosChlop = 0; }
        horizontalPosChlop += 2.5f;
        GameObject Chlop = Instantiate(chlopPrefab);
        Chlop.name = "Chlop" + numerChlopa.ToString();
        numerChlopa++;
        ListaChlopow.Add(Chlop);
        Chlop.transform.position = respawnPoint.transform.position + new Vector3(horizontalPosChlop, verticalPosChlop,0);
    }
}
