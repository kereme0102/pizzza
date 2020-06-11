using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D temas) // temas adında ikinci bir collision

    {
        if (temas.gameObject.tag == "engel") // arka planın altında sağında ve solunda belirli spritelar var bunların nedeni pizzanın kamera arkaplandan çıkmaması bu sayede onlara çarpıyor
        {
                
        }


    }
}
