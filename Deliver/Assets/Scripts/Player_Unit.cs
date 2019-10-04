using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script will act as the parent to all player unit types.
public class Player_Unit : MonoBehaviour
{
    //Attributes
    bool isSelected;

    // Start is called before the first frame update
    void Start()
    {
        isSelected = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Unit selection
    void checkSelection()
    {
        //this.GetComponent<BoxCollider>();
    }

    private void OnMouseDown()
    {
        Debug.Log("This is a friendly unit");
        isSelected = true;
    }
}
