using UnityEngine;

public class crearpuerta : MonoBehaviour
{
    public GameObject puertaprefab;
    private GameObject currentpuerta;
    public Transform PuertaHolder;
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
            currentpuerta = Instantiate(puertaprefab, PuertaHolder);
        }
    }
}
