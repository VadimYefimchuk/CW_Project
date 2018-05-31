using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {


    public int points = 1;

    public void Update()
    {

        transform.Rotate(Vector3.up, 60 * Time.deltaTime);
    }
    public void Eat()
    {

        Game.points += points;
        

        Destroy(gameObject);
        GenerateNewFood();
        
        
    }

    public static void GenerateNewFood()
    {

        GameObject food = (GameObject)Instantiate(Resources.Load("Prefabs/Food", typeof(GameObject)));

        while (true)
        {

            food.transform.position = new Vector3(Random.Range(-40, 41), 0, Random.Range(-40, 41));

            Bounds foodBounds = food.GetComponent<Collider>().bounds;

            bool intersects = false;

            foreach (Collider objectColiider in FindObjectsOfType(typeof(Collider)))
            {
                if (objectColiider != food.GetComponent<Collider>())
                {
                    if (objectColiider.bounds.Intersects(foodBounds))
                    {
                        intersects = true;
                        break;
                    }
                }

            }

            if (!intersects)
            {
                break;
            }
        }
    }

}

