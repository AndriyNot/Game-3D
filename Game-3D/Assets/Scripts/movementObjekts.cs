using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class movementObjekts : MonoBehaviour
{
    private int speed = 5;
    private GameObject kubLeft;
    public GameObject[] objekct;
    private bool index = true;
    private bool index2 = true;
    private int indexer;
    
    public GameObject text;
    private int countbloñk;
    private int countwatermelon;
    private int countmilk;

    private void Update()
    {
        if (index == true)
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        if (index2 == false)
        {
            gameObject.transform.position = kubLeft.transform.position;
        }

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("destroy"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Finish"))
        {

            index2 = true;
            indexer += 1;
            PlayerPrefs.SetInt("indexer", indexer);
            positionObjeckt();
            if (gameObject.CompareTag("box"))
            {
                int block = 1;
                countbloñk += 1;
                PlayerPrefs.SetInt("auditblock", block);
                PlayerPrefs.SetInt("countblock", countbloñk);
            }

            if (gameObject.CompareTag("watermelon"))
            {
                int indexwatermelon = 1;
                countwatermelon += 1;
                PlayerPrefs.SetInt("auditwatermelon", indexwatermelon);
                PlayerPrefs.SetInt("countwatermelon", countwatermelon);
            }

            if (gameObject.CompareTag("milk"))
            {
                int indexmilk = 1;
                countmilk += 1;
                PlayerPrefs.SetInt("auditmilk", indexmilk);
                PlayerPrefs.SetInt("countmilk", countmilk);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            index = false;
            index2 = false;
            kubLeft = other.gameObject;
        }
       
    }
    public void positionObjeckt()
    {
        int indexer = PlayerPrefs.GetInt("indexer");

        if (indexer == 1)
        {
            gameObject.transform.position = objekct[0].transform.position;
        }
        if (indexer == 2)
        {
            gameObject.transform.position = objekct[1].transform.position;
        }
        if (indexer == 3)
        {
            gameObject.transform.position = objekct[2].transform.position;
        }
        if (indexer == 4)
        {
            gameObject.transform.position = objekct[3].transform.position;
        }
        if (indexer == 5)
        {
            gameObject.transform.position = objekct[4].transform.position;
        }
    }
    
}
