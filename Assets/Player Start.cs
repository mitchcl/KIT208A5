using UnityEngine;

public class Begin : MonoBehaviour
{
    public GameObject[] trainingText;
    public GameObject trainButton;
    public GameObject testButton;
    public GameObject player;
    public GameObject teleportToStart;
    public GameObject finishButton;
    public GameObject telportToFinish;
    // Start is called before the first frame update
    void Start()
    {
        trainingText = GameObject.FindGameObjectsWithTag("Train");
    }

    // Update is called once per frame
    void Update()
    {
        if (!testButton.activeSelf)
        {
            player.transform.position = teleportToStart.transform.position;
            for (int i = 0; trainingText[i] != null; i++)
            {
                trainingText[i].SetActive(false);
            }
            testButton.SetActive(true);
        }

        if (!trainButton.activeSelf)
        {
            player.transform.position = teleportToStart.transform.position;
            trainButton.SetActive(true);
        }
        
        if (!finishButton.activeSelf) 
        {
            player.transform.position = telportToFinish.transform.position;
            finishButton.SetActive(true);
        }
    }
}      