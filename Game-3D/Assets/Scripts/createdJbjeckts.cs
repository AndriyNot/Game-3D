using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createdJbjeckts : MonoBehaviour
{
    public GameObject[] objeckts;
    private int random;
    private float timer;

    void Update()
    {
       

        timer += Time.deltaTime;
        if (timer >= 1)
        {
            random = Random.Range(0, objeckts.Length);
            Instantiate(objeckts[random], gameObject.transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
