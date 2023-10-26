using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class ScenePicker : MonoBehaviour
{

    public GameObject phone1;
    public GameObject phone2;
    public GameObject phone3;

    public GameObject knife1;
    public GameObject knife2;
    public GameObject knife3;

    public GameObject wine1;
    public GameObject wine2;
    public GameObject wine3;

    public GameObject blood1;
    public GameObject blood2;
    public GameObject blood3;

    public GameObject noBlood1;
    public GameObject noBlood2;
    public GameObject noBlood3;

    //public GameObject[] turnOffEvidence;


    // Start is called before the first frame update
    void Start()
    {
        /*turnOffEvidence = GameObject.FindGameObjectsWithTag("Evidence");

        foreach (GameObject obj in turnOffEvidence)
        {
            obj.SetActive(false);
        }
        */

        phone1.SetActive(false);
        phone2.SetActive(false); ;
        phone3.SetActive(false); ;

        knife1.SetActive(false); ;
        knife2.SetActive(false); ;
        knife3.SetActive(false); ;

        wine1.SetActive(false); ;
        wine2.SetActive(false); ;
        wine3.SetActive(false); ;

        blood1.SetActive(false); ;
        blood2.SetActive(false); ;
        blood3.SetActive(false); ;

        noBlood1.SetActive(false); ;
        noBlood2.SetActive(false); ;
        noBlood3.SetActive(false); ;

        int phone = UnityEngine.Random.Range(1, 4);
        if (phone == 1)
        {
            phone1.SetActive(true);
        }
        else if (phone == 2)
        {
            phone2.SetActive(true);
        }
        else if (phone == 3)
        {
            phone3.SetActive(true);
        }

        int knife = UnityEngine.Random.Range(1, 4);
        if (knife == 1)
        {
            knife1.SetActive(true);
        }
        else if (knife == 2)
        {
            knife2.SetActive(true);
        }
        else if (knife == 3)
        {
            knife3.SetActive(true);
        }

        int wine = UnityEngine.Random.Range(1, 4);
        if (wine == 1)
        {
            wine1.SetActive(true);
        }
        else if (wine == 2)
        {
            wine2.SetActive(true);
        }
        else if (wine == 3)
        {
            wine3.SetActive(true);
        }


    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
