using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


      
        public AudioClip[] sesDosyalari;  // ses dosyları için gerekli dizini oluşturduk
        
      
     public float sağ; // pizzanın sağa gitmesini sağlayacak değişken

    public float sol;  // pizzanın sola gitmesini sağlayacak değişken
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        


         if (Input.GetKeyDown(KeyCode.A))  // a tuşuna basılınca pizzanın sola hareket etmesini sağladık

        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left * sol);
        }


        if (Input.GetKeyDown(KeyCode.D))   // a tuşuna basılınca pizzanın sağa hareket etmesini sağladık

        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right * sağ);
        }
    }

         void OnCollisionEnter2D(Collision2D temas)  // temas adında bir collision oluşturduk
    {
        if (temas.gameObject.tag == "puan")  // eğer puan tag'i olan bir nesneye çarpar ise
        {
                  GetComponent<AudioSource>().PlayOneShot(sesDosyalari[0],  1);  // ses dosyasındaki 0'ıncı elementi çalıştır
                  Destroy(temas.gameObject); // ve çarptığı nesneyi yok et
                
        }

       
       
       
    }





     
       
       
       
    }
    

