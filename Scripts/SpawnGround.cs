using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    private float time = 0.0f;
    public float interpolationPeriod = 10f;
    [SerializeField] private Transform GroundPart;
    private void Awake()
    {
        SpawnGroundPart(new Vector3(18, -1));
        
    }

    // Update is called once per frame
    private void SpawnGroundPart(Vector3 spawnPosition)
    {
        Instantiate(GroundPart, spawnPosition, Quaternion.identity);
        
    }
    void Update()
    {
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;

            SpawnGroundPart(new Vector3(18, -1));
        }
    }
    }
