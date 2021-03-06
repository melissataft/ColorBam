﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    //public Material[] materials;//Allows input of material colors in a set size of array;
    private Renderer Rend; //What are we rendering? Input object(Sphere,Cylinder,...) to render.

    private int index = 1;//Initialize at 1, otherwise you have to hit the object twice to change colors at first.

    // Use this for initialization
    void Start()
    {
        Rend = GetComponent<Renderer>();//Gives functionality for the renderer
        Rend.enabled = true;//Makes the rendered 3d object visable if enabled;
    }


    void OnTriggerEnter(Collider c) {

        // if the bullet is the same color, we've scored!
        if (c.GetComponent<Renderer>().material.color == Rend.material.color) // Compare Tags instead
        {
            print("Score!");

            // Change cube to correct color

        }
        else
        {
            print("Wrong target :(");
        }

        /*
        if (materials.Length == 0)//If there are no materials nothing happens.
            return;

        index += 1;//When object is hit index will increment up to the next material location

        if (index == materials.Length + 1)//When it reaches the end of the materials it starts over.
            index = 1;

        print(index);//used for debugging

        Rend.sharedMaterial = materials[index - 1]; //This sets the material color values inside the index
        */
    }
}
