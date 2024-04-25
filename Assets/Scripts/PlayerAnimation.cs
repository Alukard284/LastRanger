using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    public Animator _animator;
    [SerializeField] SwitchWeapone _s_weapone;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       SetHandLayerAnimation();
        SwordAttack();
    }
    public void SetHandLayerAnimation()
    {
        if (_s_weapone.currentWeapone > 0)
        {
            _animator.SetLayerWeight(1, 1f);
        }
        else
        {
            _animator.SetLayerWeight(1, 0f);
        }
    }

    void SwordAttack()
    {
        if(_s_weapone.currentWeapone != 0) 
        {
            if(Input.GetMouseButtonDown(0))
            {
                _animator.SetTrigger("SwordAttack_1");
            }
            if (Input.GetMouseButtonDown(1))
            {
                _animator.SetTrigger("SwordAttack_2");
            }
            if (Input.GetMouseButtonDown(2))
            {
                _animator.SetTrigger("Cast");
            }
        }
    }
   
}
