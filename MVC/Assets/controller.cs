using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public view playerView;
    private model playerModel;
    // Start is called before the first frame update
    void Start()
    {
        playerModel = new model();
        playerModel.Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerModel.Health -= 10;
            playerView.UpdateHealth(playerModel.Health);
        }
    }
    public void healthinc()
    {
        playerModel.Health += 10;
        playerView.UpdateHealth(playerModel.Health);
    }
    public void healthdec()
    {
        playerModel.Health -= 10;
        playerView.UpdateHealth(playerModel.Health);
    }
    
}
