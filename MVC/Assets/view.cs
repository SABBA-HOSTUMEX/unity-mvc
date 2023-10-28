using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class view : MonoBehaviour
{
    public Text playerHealthText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHealth(int health)
    {
        playerHealthText.text = "Health: " + health;
    }
}
