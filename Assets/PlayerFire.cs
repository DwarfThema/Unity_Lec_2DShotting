using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public static PlayerFire Instance;

    public List<GameObject> bulletPool = new List<GameObject>();
    public GameObject bulletPre;

    GameObject bullet;
    int bulletMax = 10;

    public GameObject bulletFactory;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < bulletMax; i++)
        {
            bullet = Instantiate(bulletPre);
            bulletPool.Add(bullet);
            bullet.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

        if(bulletPool.Count >= 1)
        {
                bullet = bulletPool[0];
                bullet.SetActive(true);
                bullet.transform.position = bulletFactory.transform.position;
                bulletPool.RemoveAt(0);
        }

        }
    }
}
