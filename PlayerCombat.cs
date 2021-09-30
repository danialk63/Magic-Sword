using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;

    public Enemy dragon;
    public float attackRange = 10f;
    public int attackDamage = 40;
    public float attackRate = 2f;
    float nextAttackTime = 0f;


    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            //  if (Input.GetKeyDown(KeyCode.Space))
            if (Input.touchCount > 1)
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }
    void Attack()
    {
        // play an attack animation

        animator.SetTrigger("Attack");
        dragon.TakeDamage(attackDamage);

        //detect enemies in range of attack
        //Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

        // damage them 
      //  foreach (Collider enemy in hitEnemies)
       // {
       //     enemy.GetComponent<Enemy>().TakeDamage(attackDamage);

      //  }

        void OnDrawGizmosSelected()
        {
            if (attackPoint == null)
                return;
            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }
    }
}