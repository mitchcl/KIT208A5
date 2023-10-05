using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    [SerializeField] private OpenTypes openDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openDoor(){ 
        if (openDirection == OpenTypes.ROTATEUP)
        {

        }else if (openDirection == OpenTypes.ROTATEDOWN)
        {

        }else if (openDirection == OpenTypes.ROTATELEFT)
        {

        }else if (openDirection == OpenTypes.ROTATERIGHT)
        {

        }else if (openDirection == OpenTypes.SLIDEPOSX)
        {

        }else if (openDirection == OpenTypes.SLIDENEGX)
        {

        }else if (openDirection == OpenTypes.SLIDEPOSZ)
        {

        }else if (openDirection == OpenTypes.SLIDENEGZ)
        {

        }
    }
}
