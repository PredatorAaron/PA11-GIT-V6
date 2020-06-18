using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager thisManager;

    public int Score;

    public Text TextScore;

    // Start is called before the first frame update
    void Start()
    {
        thisManager = this;

        TextScore.text = "Score: " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
