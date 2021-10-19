using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject chicken;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = chicken.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        anim.Play("Eat");
    }
}
