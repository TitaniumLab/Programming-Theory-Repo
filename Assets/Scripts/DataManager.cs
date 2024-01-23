using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; } // ENCAPSULATION

    private int maxNameLenth = 15;
    private string _playerName;
    public string playerName
    {
        get { return _playerName; }
        set
        {
            if (value.Length > maxNameLenth)
            {
                _playerName = value.Substring(0, maxNameLenth);
            }
            else
            {
                _playerName = value;
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
