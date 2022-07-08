using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public static PlayerHP Instance;

    public int hp =3;
    public int HP
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;

            if(hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
