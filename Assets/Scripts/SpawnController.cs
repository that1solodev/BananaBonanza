using System.Threading;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject banana;
    public GameObject bomb;
    public GameObject Mega;
    public float z1, z2;
    public float fallheight;
    void Start()
    {
        InvokeRepeating("spawnBomb1", 0f, 0.5f);
 //       InvokeRepeating("spawnBomb2", 0.5f, 0.75f);
        InvokeRepeating("spawnBanana", 1.15f, 2f);
        InvokeRepeating("spawnBanana", 2.15f, 2f);
   //     InvokeRepeating("spawnMegaBomb", 15f, 15f);
    }

    void Update()
    {

    }
    // Update is called once per frame
  /*  void spawnMegaBomb()
    {
        Instantiate(Mega, new Vector3(0f, fallheight, 0f), Quaternion.identity);
    }*/
    void spawnBanana()
    {
        float loc = Random.Range(z1, z2);
        Vector3 pos = new Vector3(loc, fallheight, 0);
        Instantiate(banana, pos, Quaternion.identity);       
    }
    void spawnBomb1()
    {
        float loc = Random.Range(z1, z2);
        Vector3 pos = new Vector3(loc, fallheight, 0);
        Instantiate(bomb, pos, Quaternion.identity);
    }
    /*void spawnBomb2()
    {
        float loc = Random.Range(0.5f, z2);
        Vector3 pos = new Vector3(loc, fallheight, 0);
        Instantiate(bomb, pos, Quaternion.identity);
    }*/
}
