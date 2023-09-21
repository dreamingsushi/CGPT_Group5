using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnimation;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            playerAnimation.SetBool("Attack", true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerAnimation.SetBool("Attack", false);
        }
    }
}
