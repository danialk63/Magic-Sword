using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayer : MonoBehaviour
{
    public PlayerScript playerScript;
    // Start is called before the first frame update
   
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Dragon")

            {
               

                playerScript.enabled = false;
                
            }


        }
    }

