using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    private Image healthbar, lerper;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float maxHp, currentHp;

    [SerializeField]
    private float lerSpeed;

    public bool isDead;

    private void Awake()
    {
        currentHp = maxHp;
    }

    public void LoseHp(float dmg)
    {
        if (currentHp > 2)
        {
            currentHp -= dmg;
            healthbar.fillAmount = currentHp / maxHp;
            animator.SetTrigger("hit");
        }
        if (!(currentHp > 2) && isDead == false)
        {
            isDead = true;
            animator.SetTrigger("die");
        }
    }

    private void Update()
    {
        lerper.fillAmount = Mathf.Lerp(lerper.fillAmount, healthbar.fillAmount, Time.deltaTime * lerSpeed);
    }
}