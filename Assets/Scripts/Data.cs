using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Data : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static Data Instance;
    public Text Name;
    public string playerName;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        playerName = Name.text;
    }

    public void NewNameSelected()
    {
        // add code here to handle when a color is selected
        Data.Instance.playerName = playerName;
    }
}
