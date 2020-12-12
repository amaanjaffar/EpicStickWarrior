using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButton : MonoBehaviour
{
    public Transform AttackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public GameObject BadBoi;
    public Button button;
    [SerializeField] private GameObject[] NewBadBoi;
    private int randomBoi;
    private float time = 0.0f;
    public float interpolationPeriod = 5f;

    private void Awake()
    {
        
        SpawnNewBadBoi(new Vector3(10, -5));

    }


    public void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, attackRange, enemyLayers);
        
        foreach (Collider2D enemy in hitEnemies)
        {
            SpawnNewBadBoi(new Vector3(10, -5));
            ScoreCounter.scoreAmount += 1;
            Debug.Log("we hit " + enemy.name);
            BadBoi = hitEnemies[0].gameObject;
            Destroy(BadBoi);
            button.interactable = true;
            
        }
        
        
    }

    private void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(AttackPoint.position, attackRange);
    }

    private void SpawnNewBadBoi(Vector3 spawnPosition)
    {
        randomBoi = Random.Range(0, 3);
        Instantiate(NewBadBoi[randomBoi], spawnPosition, Quaternion.identity);

    }
    void Update()
    {
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;

           
        }
    }

}
