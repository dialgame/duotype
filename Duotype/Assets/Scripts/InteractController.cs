using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    public bool isOpen;
    public SpriteRenderer sr;
    

    private void Start()
    {
        
        sr = GetComponent<SpriteRenderer>();
    }

    public void OpenChest()
    {
        if (!isOpen)
        {
            isOpen = true;
            sr.color = Color.green;
            
            Debug.Log("Chest is open");
        }
    }

    
}
