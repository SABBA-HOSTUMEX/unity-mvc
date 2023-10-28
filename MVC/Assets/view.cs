using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class view : MonoBehaviour
{
    public Text playerHealthText;
    public Button btninc;
    public Button btndec;
    public controller controscript;
    // Start is called before the first frame update
    void Start()
    {
        btninc.onClick.AddListener(IncreaseHealth);
        btndec.onClick.AddListener(DecreaseHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHealth(int health)
    {
        playerHealthText.text = "Health: " + health;
    }
    public void IncreaseHealth()
    {
        controscript.healthinc(); 
    }
    public void DecreaseHealth()
    {
        controscript.healthdec();      
    }
}
