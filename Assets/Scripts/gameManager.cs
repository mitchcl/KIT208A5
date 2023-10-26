using OVR.OpenVR;
using SojaExiles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Callbacks;

public class gameManager : MonoBehaviour
{
    public TMP_Text ScoreDisplay;
    [SerializeField] private float pictureCountTotal = 7;
    [SerializeField] private float currentPictureCount = 0;
    [SerializeField] private float baggedCountTotal = 4;
    [SerializeField] private float currentBaggedEvidenceCount = 0;
    [SerializeField] private float doorCountTotal = 61;
    [SerializeField] private float currentOpenedCount = 0;
    [SerializeField] private float tickCountTotal = 3;
    [SerializeField] private float tickCount = 0;


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
        Tick.reportTick += incrementTick;




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
        Tick.reportTick -= incrementTick;
    }

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        displayScore();
    }

    private void displayScore()
    {
        float evidenceTotal = pictureCountTotal + baggedCountTotal;
        float evidenceCurrent = currentPictureCount + currentBaggedEvidenceCount;
        float percentageEvidenceComplete = (evidenceCurrent / evidenceTotal) * 100;
        float percentageDoorsComplete = (currentOpenedCount / doorCountTotal) * 100;
        float percentageEvidenceCompleteFinal = (evidenceCurrent / evidenceTotal) * 70;
        float percentageDoorsCompleteFinal = (currentOpenedCount / doorCountTotal) * 30;
        float percentageFinal = (percentageEvidenceCompleteFinal + percentageDoorsCompleteFinal);
        if (tickCount == tickCountTotal)
        {
            //Debug.Log("Evidence found and processed: " + percentageEvidenceComplete.ToString("F2") + "% \n" + "Search Thoroughness: " + percentageDoorsComplete.ToString("F2") + "% \n" + "Final Score: " + percentageFinal.ToString("F2") + "%");
            ScoreDisplay.SetText("Evidence found and processed: " + percentageEvidenceComplete.ToString("F2") + "% \n" + "Search Thoroughness: " + percentageDoorsComplete.ToString("F2") + "% \n" + "Final Score: " + percentageFinal.ToString("F2") + "%");

        }
        else
        {
            ScoreDisplay.SetText("Evidence found and processed: " + percentageEvidenceComplete.ToString("F2") + "% \n" + "Search Thoroughness: " + percentageDoorsComplete.ToString("F2") + "% \n" + "Final Score: 0% \n Failed to equip essential gear");
        }

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

    private void incrementTick()
    {
        tickCount++;
    }

    public float getCurrentOpenedCount()
    {
        return currentOpenedCount;
    }


}
