using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;

    public UnityEvent onCollide;

    AudioSource audSource;

    void Start()
    {
        audSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        move();
    }

    void move()
    {
        float movez = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(0, 0, movez);

        float rotatey = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, rotatey, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {
            onCollide.Invoke();
            audSource.Play();
            transform.position = new Vector3(0, 1, -7);
        }
    }
}
