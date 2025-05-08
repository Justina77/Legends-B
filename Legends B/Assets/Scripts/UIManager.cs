using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image healthGlode, manaGlobe;
    [SerializeField] private Slider xpSlider;
    [SerializeField] private PlayerHealth health;

    void Start()
    {
        
    }


    void Update()
    {
        healthGlobe.fillAmount = Mathf.Lerp(health.GetHealthRatio(), healthGlobe.fillAmount, 2 * Time.deltaTime);
    }
}
