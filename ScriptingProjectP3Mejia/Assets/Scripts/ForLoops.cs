using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    
        int numEnemies = 3;


        void Start()
        {
            for (int i = 0; i < numEnemies; i++)
            {
                Debug.Log("Creating enemy number: " + i);
            }
        }
 }


