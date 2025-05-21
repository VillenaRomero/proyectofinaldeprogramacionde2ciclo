using UnityEngine;

public class crearotrapalanca : MonoBehaviour
{
    public GameObject palanca2prefab;
    private GameObject currentpalanca2;
    public Transform palanca2Holder;
    public string nametag = "player";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == nametag)
        {
            currentpalanca2 = Instantiate(palanca2prefab, palanca2Holder);
        }
    }


    /*public GameObject prefabEnemy;
    public float minXposition;
    public float maxXposition;
    public float yPosition;
    private void Start()
    {
        Createenemy();
    }
    void Createenemy()
    {
        float xposition = Random.Range(minXposition, maxXposition);
        Vector2 positioncreate = new Vector2(xposition, yPosition);
        GameObject moneda = Instantiate(prefabEnemy, positioncreate, transform.rotation);
        Invoke("Createenemy", 1.0f);
    }*/
}
