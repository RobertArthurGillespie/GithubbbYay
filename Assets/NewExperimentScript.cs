using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewExperimentScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Yoooooooooooo"); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is the new thing");  
    }
}

[CreateAssetMenu(fileName = "Obamna", menuName = "Create Obamna/Obamna")]
public abstract class ObamnaReborn : ScriptableObject
{
    public string Text = "You have created a new Obamna";
}
