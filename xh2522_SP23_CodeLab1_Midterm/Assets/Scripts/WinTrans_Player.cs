using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrans_Player : MonoBehaviour
{
    public GameObject PlayerBall;
    public GameObject Puzzle1;
    public GameObject WASD;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
   private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.GetComponent<ASCIILevel>().levelLoad();
        Destroy(gameObject);
        Destroy(PlayerBall);
        Destroy(Puzzle1);
        WASD.SetActive(true);
    }

   

}
