using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image healthGlobe, manaGlobe;
    [SerializeField] private Slider xpSlider;
    [SerializeField] private PlayerHealth health;
    [SerializeField] private TMP_Text levelText;

    public void UpdateLevelText(int level)
    {
        levelText.text = level.ToString();
    }

    void Start()
    {
        
    }


    void Update()
    {
        healthGlobe.fillAmount = Mathf.Lerp(healthGlobe.fillAmount, health.GetHealthRatio(), 2 * Time.deltaTime);
    }

    public void UpdateXpSlider(float xpRatio)
    {
        xpSlider.value = xpRatio;
    }
}
