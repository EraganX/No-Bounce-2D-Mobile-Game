using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public static int randomBallers;

    private void Start()
    {
        StartCoroutine("BallSpawn");
    }

    IEnumerator BallSpawn()
    {
        int i = 0;
        randomBallers = Random.Range(4,10);
        
        while (randomBallers>i)
        {
            float randomSize = Random.Range(0.4f, 1f);
            Vector3 loaction = Random.insideUnitCircle * 3f;
            Color color = new Color(Random.value,Random.value,Random.value);

            GameObject ball =Instantiate(ballPrefab,new Vector3(transform.position.x+ loaction.x, transform.position.y + loaction.y,transform.position.z),Quaternion.identity);
            ball.transform.localScale = new Vector3(randomSize, randomSize, randomSize);
            ball.GetComponent<Renderer>().material.color = color;
            i++;
            yield return null;
        }
        
    }
}
