using OVR.OpenVR;
using SojaExiles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    private int currentPictureCount = 0;
    private int currentBaggedEvidenceCount = 0;
    [SerializeField] private int doorCount = 69;
    [SerializeField] private int currentOpenedCount = 0;

    private void OnEnable()
    {
        TableFlipL.reportDoorCheck += addToCount;
        ClosetopencloseDoor.reportDoorCheck += addToCount;
        opencloseDoor1.reportDoorCheck += addToCount;
        opencloseDoor.reportDoorCheck += addToCount;
        OvenFlip.reportDoorCheck += addToCount;
        opencloseSlide.reportDoorCheck += addToCount;
        Drawer_Pull_Zopp.reportDoorCheck += addToCount;
        Drawer_Pull_X.reportDoorCheck += addToCount;
        Drawer_Pull_Z.reportDoorCheck += addToCount;
        TakePicture.reportPictureTaken += addToPictureCount;
        BagEvidence.reportBaggedEvidence += addToEvidenceBagCount;
        


    }

    private void OnDisable()
    {
        TableFlipL.reportDoorCheck -= addToCount;
        ClosetopencloseDoor.reportDoorCheck -= addToCount;
        opencloseDoor1.reportDoorCheck -= addToCount;
        opencloseDoor.reportDoorCheck -= addToCount;
        OvenFlip.reportDoorCheck -= addToCount;
        opencloseSlide.reportDoorCheck -= addToCount;
        Drawer_Pull_Zopp.reportDoorCheck -= addToCount;
        Drawer_Pull_X.reportDoorCheck -= addToCount;
        Drawer_Pull_Z.reportDoorCheck -= addToCount;
        TakePicture.reportPictureTaken -= addToPictureCount;
        BagEvidence.reportBaggedEvidence -= addToEvidenceBagCount;
    }

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void addToCount (bool hasDoorBeenOpenedAtLeastOnce){
        UnityEngine.Debug.Log("I get to addToCount");
        if (hasDoorBeenOpenedAtLeastOnce == false)
        {
            currentOpenedCount++;
        }
        
    }

    private void addToPictureCount(bool hasTakenPicture)
    {
        if (hasTakenPicture)
        {
           
            currentPictureCount++;
            UnityEngine.Debug.Log("Taken picture, current count is: " + currentPictureCount);
        }
    }

    private void addToEvidenceBagCount(bool hasBaggedEvidence)
    {
        if (hasBaggedEvidence)
        {

            currentBaggedEvidenceCount++;
            UnityEngine.Debug.Log("Bagged evidence, current count is: " + currentBaggedEvidenceCount);
        }
    }

    public int getCurrentOpenedCount()
    {
        return currentOpenedCount;
    }


}
