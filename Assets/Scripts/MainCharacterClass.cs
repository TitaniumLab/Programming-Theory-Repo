using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class MainCharacterClass : MonoBehaviour
{
    protected int maximumLife = 20;
    protected int _currentLife = 20;
    public int currentLife
    {
        get { return _currentLife; }
        set
        {
            if (value > maximumLife)
                _currentLife = maximumLife;
            else if (value < 0)
                Time.timeScale = 0;
            else
            {
                _currentLife = value;
                slider.value = _currentLife;
            }

        }
    }
    protected int minDamage = 3;
    protected int maxDamage = 5;
    [SerializeField]
    protected GameObject weapon;
    protected Player player;
    protected Slider slider;


    private void Start()
    {
        slider = GetComponentInChildren<Slider>();
        player = GetComponentInParent<Player>();
        slider.maxValue = maximumLife;
        slider.value = _currentLife;
    }
    private void FixedUpdate()
    {
        slider.transform.rotation = Camera.main.transform.rotation;
    }

    public int RandomDamage()
    {
        int value = Random.Range(minDamage, maxDamage + 1);
        Debug.Log($"Enemy get {value} damage.");
        return value;
    }

    protected abstract void Attack();

}
