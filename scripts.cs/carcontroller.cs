
using UnityEngine;

public class carcontroller : MonoBehaviour
{
    public float carspeed;
    public float maxpos = 2.2f;
    
    
    Vector3 position;
    public uiManager ui;
    void Start()
    {
        
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * carspeed * Time.deltaTime;

        position.x = Mathf.Clamp(position.x, -6.28f, 6.28f);

        transform.position = position;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            ui.gameOverOn();
        }
    }
}
