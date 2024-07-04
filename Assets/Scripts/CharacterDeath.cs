using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDeath : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Meteor"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            

        }
        
    }
}
