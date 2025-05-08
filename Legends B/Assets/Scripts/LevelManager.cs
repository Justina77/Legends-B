using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private int currentXP;
    private int currentLevel = 1;
    public static LevelManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void GiveXP(int xpToGive)
    {
        currentXP += xpToGive;
        Debug.Log("current XP: " + currentXP);
        CalculateLevel();
    }

    private void CalculateLevel()
    {

    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
