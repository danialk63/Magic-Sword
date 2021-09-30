using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;

    public Score score;
    public GameOverController gameOverController;
    public AudioSource audioSource;
   

    public Transform swordInHand;
    public Transform swordInHandTwo;
    public Transform swordInHandThree;
    public Transform swordInHandFour;
    public Transform swordInHandFive;
    public Transform swordInHandSix;
    public Transform swordInHandSeven;





    //  public Transform playerTransform;
    public SwipeUp swipeUp;
    public TouchLeftRight touchLeftRight;
   // private void OnCollisionEnter(Collision other)
    // {
  //  Debug.Log("Collision deteacted");
   //  if(other.gameObject.tag == "Collectables")
    // {
     //    Destroy(other.gameObject);
    // }

   private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Collectables" )
        {
            audioSource.Play();
            Destroy(other.gameObject);
            score.AddScore(1);


          //  transform.position = transform.position + new Vector3(0, 1.5f, 0);
            
       }
       if(other.gameObject.tag == "Sword")
        {
            transform.localScale = new Vector3(1.53779786f, 1.6f, 1.36800003f);

            swordInHand.gameObject.SetActive(true);
           
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "SwordTwo")
        {
           transform.localScale = new Vector3(1.57779786f, 1.63f, 1.36800003f);
            swordInHand.gameObject.SetActive(false);
            swordInHandTwo.gameObject.SetActive(true);

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "SwordThree")
        {
            swordInHandTwo.gameObject.SetActive(false);

            swordInHandThree.gameObject.SetActive(true);

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "SwordFour")
        {
            transform.localScale = new Vector3(1.61779786f, 1.66f, 1.36800003f);
            
            swordInHand.gameObject.SetActive(false);
            swordInHandTwo.gameObject.SetActive(false);
            swordInHandFive.gameObject.SetActive(false);
            swordInHandSix.gameObject.SetActive(false);
            swordInHandSeven.gameObject.SetActive(false);
            swordInHandFour.gameObject.SetActive(true);

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "SwordFive")
        {
            transform.localScale = new Vector3(1.62779786f, 1.670f, 1.36800003f);
            swordInHand.gameObject.SetActive(false);
            swordInHandTwo.gameObject.SetActive(false);
            swordInHandFour.gameObject.SetActive(false);
           
            swordInHandFive.gameObject.SetActive(true);

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "SwordSix")
        {
            transform.localScale = new Vector3(1.50779786f, 1.665f, 1.36800003f);
            swordInHand.gameObject.SetActive(false);
            swordInHandTwo.gameObject.SetActive(false);
            
            swordInHandFour.gameObject.SetActive(false);
            swordInHandFive.gameObject.SetActive(false);
           
            swordInHandSix.gameObject.SetActive(true);

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "SwordSeven")
        {
            transform.localScale = new Vector3(1.58779786f, 1.66f, 1.36800003f);
            swordInHand.gameObject.SetActive(false);
            swordInHandTwo.gameObject.SetActive(false);
            swordInHandFour.gameObject.SetActive(false);
            swordInHandFive.gameObject.SetActive(false);
            swordInHandSix.gameObject.SetActive(false);
            swordInHandSeven.gameObject.SetActive(true);


            Destroy(other.gameObject);
        }


    }

   // private void OnTriggerEnter(Collider other)
    //{
     //   if (other.gameObject.tag == "Sword")
      //  {

        //    Destroy(other.gameObject);

     //   }
  //  }

  //  private void OnCollisionEnter(Collider other)
   // {
     //   if (other.gameObject.tag == "Sword")
      //  {
            
       //     Destroy(other.gameObject);

      //  }
 //   }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")

        {
            gameOverController.GameOver();

            playerScript.enabled = false;
            swipeUp.enabled = false;
            touchLeftRight.enabled = false;

            
        }


    }

}

