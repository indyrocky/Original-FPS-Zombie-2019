using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;

    [SerializeField] float damage = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitAnimEvent()
    {
        if (target == null)
        {
            return;
        }

        target.TakeDamage(damage);

        target.GetComponent<DisplayDamage>().ShowPlayerDamageCanvas();

        Debug.Log("Player smacked");
    }
}
