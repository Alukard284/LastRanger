using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerAnimation _playerAnimation;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
    }
    
    public void Inputs()
    {
        vertical = Input.GetAxis("Vertical");
        _playerAnimation._animator.SetFloat("Movement", vertical);
    }
}
