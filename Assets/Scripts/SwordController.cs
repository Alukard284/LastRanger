using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SwordController : MonoBehaviour
{
    private Animator s_Animator;
    [SerializeField] SwitchWeapone _switchWeapone;
    // Start is called before the first frame update
    void Start()
    {
        s_Animator = GetComponent<Animator>();
    }

    private void Update()
    {
        SwordStartAnimation();
    }
    void SwordStartAnimation()
    {
        if (_switchWeapone.currentWeapone == 1)
        {
            s_Animator.SetBool("isActive", true);

        }
        else
        {
            s_Animator.SetBool("isActive", false);

        }
    }
}
