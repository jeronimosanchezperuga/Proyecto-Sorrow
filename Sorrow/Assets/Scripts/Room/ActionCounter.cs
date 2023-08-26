using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionCounter : MonoBehaviour
{
    int doneActions = 0;

    [SerializeField] int neededActions;
    public void ActionDone()
    { 
        doneActions++;
        if(doneActions == neededActions)
        {
            print("All actions done");
            Destroy(gameObject);
        }
    }
}
