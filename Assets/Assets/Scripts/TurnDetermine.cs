using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnDetermine : MonoBehaviour
{
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float seconds = timer % 60;
        if (seconds % 10 < 5)
        {
            Movement.P2turn = true;
            Movement.P1turn = false;
        }
        else if (seconds % 10 > 5)
        {
            Movement.P2turn = false;
            Movement.P1turn = true;
        }
    }
}
