using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour

{
    public float speed = 1;
    private bool _testing = false;
    
    public GameObject SnakeBody;
    public List<GameObject> BodySnake = new List<GameObject> { };

    public float rotationSpeed = 60;

    private CharacterController _controller;

    public void Start()
    {
        BodySnake.Clear();
        _controller = GetComponent<CharacterController>();
        }


    public void Update()
    {
         SnakeStap();

        float horizontal = Input.GetAxis("Horizontal");

          transform.Rotate(rotationSpeed * Time.deltaTime * horizontal,0, 0);
        
        _testing = true; 
        _controller.Move(transform.forward * speed * Time.deltaTime );


    }
    void SnakeStap() {
        if (BodySnake.Count > 0)
        {
            BodySnake[0].transform.position = transform.position;
            for (int BodyIndex = BodySnake.Count - 1; BodyIndex > 0; BodyIndex--)
                BodySnake[BodyIndex].transform.position = BodySnake[BodyIndex - 1].transform.position;
        }
    }
    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (_testing)
        {
            Food food = hit.collider.GetComponent<Food>();
            if (food != null)
            {
                food.Eat();
            }
            else
            {
                Debug.Log(hit.gameObject.name);
                SceneManager.LoadScene ("GameOver");
            }
            _testing = false;
        }
    }

}

