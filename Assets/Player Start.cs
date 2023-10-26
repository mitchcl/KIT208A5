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

    bool train = true;
    bool test = true;
    // Start is called before the first frame update
    void Start()
    {
        trainingText = GameObject.FindGameObjectsWithTag("Train");
        //for (int i = 0; trainingText[i] != null; i++)
        //{
            //UnityEngine.Debug.Log(trainingText[i].name);
        //}
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!testButton.activeSelf)
        {
            if (test)
            {
                player.transform.position = teleportToStart.transform.position;
                player.transform.position = teleportToStart.transform.position;
                player.transform.position = teleportToStart.transform.position;

                foreach (GameObject obj in trainingText)
                {
                    UnityEngine.Debug.Log("I am in the loop");
                    obj.SetActive(false);
                }
                testButton.SetActive(true);
                test = false;
            }
        }

        if (!trainButton.activeSelf)
        {
            if (train)
            {
                player.transform.position = teleportToStart.transform.position;
                trainButton.SetActive(true);
                train = false;
            }
        }
        
        if (!finishButton.activeSelf) 
        {
            player.transform.position = telportToFinish.transform.position;
            finishButton.SetActive(true);
        }
    }
}      