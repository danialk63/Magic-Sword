using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinalScript : MonoBehaviour
{
   
        public void OnTriggerEnter(Collider other)
        {

        Debug.Log("ABCCCC");
            if (other.gameObject.tag == "Boss")
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
 }

