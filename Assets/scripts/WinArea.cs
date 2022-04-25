using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinArea : MonoBehaviour
{
    public string newLvL;
    public RectTransform winPanel;

    // Start is called before the first frame update
    void Start()
    {
        wincanv.GameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
       
        
        if (other.CompareTag("Player"))
        {
           wincanv.GameObject.SetActive(true);
        }

    }
    public void LoadNewLevel()
    {
        SceneManager.LoadScene(newLvL);
    }

}
