using System.Collections;
using System.Collections.Generic;
using UnityEngine;




// 죽을 때 폭발효과 발생시키고 싶다.
// 필요속성 : 폭발효과 공장
public class EnemyMove : MonoBehaviour
{
    public float speed = 0.8f;

    Vector3 dir;

    GameObject target;

    GameObject explosionPre;


    // Start is called before the first frame update
    void Start()
    {
        explosionPre = Resources.Load("Prefabs/Explosion") as GameObject;

        target = GameObject.Find("Player");

        int random = Random.Range(1, 10);
        if(random < 7 && target)
        {
            dir = target.transform.position - transform.position;
        }
        else
        {
            dir = Vector3.down;
        }

        dir.Normalize();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Bullet"))
        {
            other.gameObject.SetActive(false);
            PlayerFire.Instance.bulletPool.Add(other.gameObject);
        }
        else if (other.gameObject.name.Contains("Player"))
        {
            PlayerHP.Instance.HP--;
        }

        GameObject explosion = Instantiate(explosionPre);
        explosion.transform.position = transform.position;
        Destroy(gameObject);
    }
}
