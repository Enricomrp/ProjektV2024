using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public int kills;
    [SerializeField]
    SpriteRenderer mr;
    [SerializeField]
    BoxCollider2D bc2d;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (kills > 4)
        {
            mr.enabled = false;
            bc2d.enabled = false;
        }
    }
}
