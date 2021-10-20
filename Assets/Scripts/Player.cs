using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -2.9f, 4.9f), transform.position.z);
    }

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
