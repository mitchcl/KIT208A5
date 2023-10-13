using OVR.OpenVR;
using SojaExiles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    [SerializeField] private int doorCount = 69;
    [SerializeField] private int currentOpenedCount = 0;

    private void OnEnable()
    {
        ClosetopencloseDoor.reportDoorCheck += addToCount;
        opencloseDoor1.reportDoorCheck += addToCount;
        opencloseDoor.reportDoorCheck += addToCount;
        OvenFlip.reportDoorCheck += addToCount;
        opencloseSlide.reportDoorCheck += addToCount;
        Drawer_Pull_Zopp.reportDoorCheck += addToCount;
        Drawer_Pull_X.reportDoorCheck += addToCount;
        Drawer_Pull_Z.reportDoorCheck += addToCount;

    }

    private void OnDisable()
    {
        ClosetopencloseDoor.reportDoorCheck -= addToCount;
        opencloseDoor1.reportDoorCheck -= addToCount;
        opencloseDoor.reportDoorCheck -= addToCount;
        OvenFlip.reportDoorCheck -= addToCount;
        opencloseSlide.reportDoorCheck -= addToCount;
        Drawer_Pull_Zopp.reportDoorCheck -= addToCount;
        Drawer_Pull_X.reportDoorCheck -= addToCount;
        Drawer_Pull_Z.reportDoorCheck -= addToCount;
    }

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void addToCount (){
        currentOpenedCount++;
    }


}
