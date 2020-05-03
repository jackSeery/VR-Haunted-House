using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void HubScene()
    {
        SceneManager.LoadScene("samplescene");
    }

    public void BowlingScene()
    {
        SceneManager.LoadScene("Advanced_Bowling_Demo");
    }
}
