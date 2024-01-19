using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MainClass : MonoBehaviour
{
    protected int maximumLife = 20;
    protected int currentLife = 20;

    //default perks
    protected List<(string perkName, int perkLevel, int[] perkModArr)> perkList = new List<(string perkName, int perkLevel, int[] perkModArr)>();
    protected (string perkName, int perkCurrLevel, int[] perkModArr) addMaxLife = new("Maximum life", 0, new int[] { 2, 3, 4, 5, 6 });

    private void Start()
    {

    }





    protected abstract void Attack();
}
