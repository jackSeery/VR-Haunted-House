using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void HubScene()
    {
        SceneManager.LoadScene("Demo Hub");
    }

    public void BowlingScene()
    {
        SceneManager.LoadScene("Advanced_Bowling_Demo");
    }

    public void BasketballScene()
    {
        SceneManager.LoadScene("Basketball_Demo");
    }

    public void GalaxyScene()
    {
        SceneManager.LoadScene("Galaxy");
    }

    public void LiquidScene()
    {
        SceneManager.LoadScene("Liquid_Physics_Demo");
    }
}
