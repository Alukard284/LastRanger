using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class SwitchWeapone : MonoBehaviour
{
    [SerializeField] Transform[] weapone;
    [SerializeField] public int currentWeapone = 0;

    private PlayerAnimation _playerAnimation;
    private void Start()
    {
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    void Update()
    {
       SelectWeapone();
       InputWeaoneSelect();
    }

    void SelectWeapone()
    {
        int i = 0;  
        foreach (Transform weapone in weapone)
        {
            if(i == currentWeapone)
                weapone.gameObject.SetActive(true);
            else
            weapone.gameObject.SetActive(false);
            i++;
        }
    }

    public void InputWeaoneSelect()
    {
        if(Input.GetAxisRaw("Mouse ScrollWheel") > 0)
        {
            if(currentWeapone >= weapone.Length -1)
            {
                currentWeapone = 0;
            }
            else
            { 
                currentWeapone++;
            }
        }

        if (Input.GetAxisRaw("Mouse ScrollWheel") < 0)
        {
            if (currentWeapone <= 0)
            {
                currentWeapone = weapone.Length -1;
            }
            else
            {
                currentWeapone--;
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            currentWeapone = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            currentWeapone = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            currentWeapone = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            currentWeapone = 3;
        }
    }
}
