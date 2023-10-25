using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisible : MonoBehaviour
{

    public GameObject BloodTile;
    public GameObject NotBloodTile;
    public bool isBloodTileActive = false;
    // Start is called before the first frame update
    
    public void ToggleVisiblity()
    {
        if (isBloodTileActive == false)
        {
            isBloodTileActive = true;
            BloodTile.SetActive(true);
            NotBloodTile.SetActive(false);
        }
    }

}
