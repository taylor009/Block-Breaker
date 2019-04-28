using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //paramaters
    [SerializeField] int breakableBlocks;  //Serialize for debugging purpose.

    //cache ference
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }


    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestoryed()
    {
        breakableBlocks--;
        if(breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }

}
