using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int _playerHealth;

    public void HealPlayer()
    {
        Debug.Log("Heal!");
    }
}
