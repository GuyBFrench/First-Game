using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] float speed = 6.0f;
    
    public bool canPlay;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public bool CanRun
    {
        get => canPlay;
        set => canPlay = value;
    }

    // Update is called once per frame
    void Update()
    {
        if(canPlay == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }

       
        }
            
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            canPlay = false;
        }
        
    }
}
