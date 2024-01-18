using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    private int maxNameLenth = 15;
    public string playerName
    {
        get { return playerName; }
        set
        {
            if (value.Length > maxNameLenth)
            {
                playerName = value.Substring(0, maxNameLenth);
            }
            else
            {
                playerName = value;
            }
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
