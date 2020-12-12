using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadGuyKill : MonoBehaviour
{
    public Transform AttackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public GameObject GoodBoi;
    public Button button;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision name = " + collision.gameObject.name);
        if (collision.gameObject.name == "NewAndImprovedStickBoi")
        {
            button.interactable = false;
            Time.timeScale = 0f;
            Destroy(collision.gameObject);
            
        }
    }
   
}
