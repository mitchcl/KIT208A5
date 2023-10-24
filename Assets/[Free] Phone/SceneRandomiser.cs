using System;
using UnityEngine;


public class SceneRandomiser : MonoBehaviour
{
    public GameObject phone1;
    public GameObject phone2;
    public GameObject phone3;
    // Start is called before the first frame update
    void Start()
    {
        int num = UnityEngine.Random.Range(1,4);

        switch(num)
        {
            case 1: phone1.SetActive(true); 
                    break;

            case 2: phone2.SetActive(true); 
                    break;

            case 3: phone3.SetActive(true); 
                    break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
