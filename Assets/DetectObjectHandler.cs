using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObjectHandler : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitObject;
            if(Physics.Raycast(ray, out hitObject))
            {
                print(string.Format("You have clicked on {0}", hitObject));
            }
        }
    }
}
