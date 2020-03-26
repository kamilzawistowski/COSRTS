using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Biblioteka : MonoBehaviour
{
    public bool BiblitekaCzy = false;
    Text CzyTrue;
    public GameObject BibliotekaPrefab;
    GameObject Bibliotekaa;
    GameObject BibliotekaP;

    private void Start()
    {
        BibliotekaPrefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefab/Biblioteka.prefab", typeof(GameObject));

        Button biblio = GetComponent<Button>();
        biblio.onClick.AddListener(OnClickBiblioteka);
    }
    private void Update()
    {
        if (BiblitekaCzy == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                BibliotekaP = Instantiate(BibliotekaPrefab);
                BibliotekaP.SetActive(false);
                BibliotekaP.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
                BibliotekaP.SetActive(true);
                BiblitekaCzy = false;
            }
        }

    }
    public void OnClickBiblioteka()
    {
        BiblitekaCzy = true;
    }
}
