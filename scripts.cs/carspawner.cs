
using UnityEngine;

public class carspawner : MonoBehaviour
{
    public GameObject[] cars;
    int carNo;
    public float maxpos;
    public float delayTimer;
    float timer;

    void Start()
    {

        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer<= 0)
        {
            Vector3 carpos = new Vector3(Random.Range(-6.28f, 6.28f), transform.position.y, transform.position.z);
            carNo = Random.Range(0, 5);
            Instantiate(cars[carNo], carpos, transform.rotation);
            timer = delayTimer;

        }
        
    
    }
        
}
