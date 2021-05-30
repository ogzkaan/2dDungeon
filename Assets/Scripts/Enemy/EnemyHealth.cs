using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class EnemyHealth : Health,IDamagable<int>
{
    public SpriteRenderer spriteRenderer;
    public int maxHealth = 6;


    private void Awake()
    {
        health = maxHealth;
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        HitFeedBack();
        if (CheckIfDead())
        {
            OnDeath();
        }
    }
    protected override void HitFeedBack()
    {
        Tween colorTween = spriteRenderer.DOBlendableColor(Color.red, 0.1f);
        colorTween.OnComplete(() => spriteRenderer.DOBlendableColor(Color.gray , 0.1f));
    }
    protected override void OnDeath()
    {
        base.OnDeath();
        Tween colorTween = spriteRenderer.DOBlendableColor(Color.red, 0.1f);
        colorTween.OnComplete(() => Destroy(gameObject));
    }
}
