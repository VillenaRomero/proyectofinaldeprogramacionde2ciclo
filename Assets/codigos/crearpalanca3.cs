using UnityEngine;

public class crearpalanca3 : MonoBehaviour
{
    public GameObject palanca3prefab;
    private GameObject currentpalanca3;
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
            currentpalanca3 = Instantiate(palanca3prefab, palanca2Holder);
        }
    }
}
