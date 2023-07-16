using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Animations.Rigging;

public class taskGeneration : MonoBehaviour
{
    public Animator animator;
    private int auditblock;
    private int auditwatermelon;
    private int auditmilk;
    public TextMeshProUGUI texttask;
    public TextMeshProUGUI textcountbox;
    public TextMeshProUGUI textcountwatermelon;
    public TextMeshProUGUI textcountmilk;
    private int random;
    private int randomimageTask;
    public GameObject[] ImageTask;
    private int countblock;
    private int countwatermelon;
    private int countmilk;
    public RigBuilder rigBuilder;
    public bool winindex = true;
    public bool lossindex = true;
    public GameObject textLoss;
    public GameObject textWin;
    public GameObject buttonLevel;
    public GameObject buttonrestartLevel;
    public GameObject buttonPanel;
    public GameObject[] textCountobjeckt;
    private void Awake()
    {
        //ImageTask[0].SetActive(false);
        //ImageTask[1].SetActive(false);
    }
    private void Start()
    {
        PlayerPrefs.DeleteAll();
        generationtask();
        int index = 0;
        PlayerPrefs.SetInt("block", index);
    }
    private void Update()
    {
        auditblock = PlayerPrefs.GetInt("auditblock");
        countblock = PlayerPrefs.GetInt("countblock");

        auditwatermelon = PlayerPrefs.GetInt("auditwatermelon");
        countwatermelon = PlayerPrefs.GetInt("countwatermelon");

        auditmilk = PlayerPrefs.GetInt("auditmilk");
        countmilk = PlayerPrefs.GetInt("countmilk");


        if (auditblock == 1 )
        {
            animator.SetBool("play", true);
            int audit = 0;
            PlayerPrefs.SetInt("auditblock", audit);
        }
        if (auditwatermelon == 1)
        {
            animator.SetBool("play", true);
            int audit = 0;
            PlayerPrefs.SetInt("auditwatermelon", audit);
        }
        if (auditmilk == 1)
        {
            animator.SetBool("play", true);
            int audit = 0;
            PlayerPrefs.SetInt("auditmilk", audit);
        }
        else
        {
            animator.SetBool("play", false);
        }

        audit();



        if (randomimageTask == 1)
        {
            textcountbox.text = "" + countblock;
            textCountobjeckt[0].SetActive(true);
        }
        if (randomimageTask == 2)
        {
            textcountwatermelon.text = "" + countwatermelon;
            textCountobjeckt[1].SetActive(true);
        }
        if (randomimageTask == 3)
        {
            textcountmilk.text = "" + countmilk;
            textCountobjeckt[2].SetActive(true);
        }
        if (randomimageTask == 1 && auditwatermelon == 1 || randomimageTask == 3 && auditwatermelon == 1)
        {
            Debug.Log("loss");
            lossindex = false;
            textLoss.SetActive(true);
            buttonrestartLevel.SetActive(true);
            buttonPanel.SetActive(false);
        }
        if (randomimageTask == 2 && auditblock == 1 || randomimageTask == 3 && auditblock == 1)
        {
            Debug.Log("loss");
            lossindex = false;
            textLoss.SetActive(true);
            buttonrestartLevel.SetActive(true);
            buttonPanel.SetActive(false);
        }
        if (randomimageTask == 1 && auditmilk == 1 || randomimageTask == 2 && auditmilk == 1)
        {
            Debug.Log("loss");
            lossindex = false;
            textLoss.SetActive(true);
            buttonrestartLevel.SetActive(true);
            buttonPanel.SetActive(false);
        }
    }

    public void generationtask()
    {
        randomimageTask = Random.Range(1, ImageTask.Length);
        ImageTask[randomimageTask].SetActive(true);
         random = Random.Range(1, 5);
        texttask.text = "" + random;
    }

    public void audit()
    {

        if (countblock == random)
        {
           
            Debug.Log("yes");
            textWin.SetActive(true);
            winindex = false;
            buttonLevel.SetActive(true);
            buttonPanel.SetActive(false);
        }
        if (countwatermelon == random)
        {

            
            textWin.SetActive(true);
            winindex = false;
            buttonLevel.SetActive(true);
            buttonPanel.SetActive(false);
        }
        if (countmilk == random)
        {


            textWin.SetActive(true);
            winindex = false;
            buttonLevel.SetActive(true);
            buttonPanel.SetActive(false);
        }
    }

   
    public void buttonNextLevel()
    {
        SceneManager.LoadScene("SampleScene");
       
    }
    
}
