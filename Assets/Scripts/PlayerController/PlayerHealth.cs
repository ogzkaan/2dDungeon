using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class PlayerHealth : Health,IDamagable<int>
{
    public GameObject herathContainer;
    public SpriteRenderer spriteRenderer;

    private float fillValue;
    public static int maxHealth=6;

    private void Awake()
    {
        health = maxHealth;
        herathContainer.GetComponent<Image>().fillAmount = 6f;
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        HealthBar();
        HitFeedBack();
        if (CheckIfDead())
        {
            OnDeath();
        }
    }
    protected override void HitFeedBack()
    {
        Tween colorTween = spriteRenderer.DOBlendableColor(Color.red, 0.1f);
        colorTween.OnComplete(() => spriteRenderer.DOBlendableColor(Color.white, 0.1f));
    }
    protected override void OnDeath()
    {
        base.OnDeath();
        Tween colorTween = spriteRenderer.DOBlendableColor(Color.white, 0.1f);
        colorTween.OnComplete(() => Destroy(gameObject));
    }
    private void HealthBar()
    {
        fillValue = (float)health / (float)maxHealth;
        herathContainer.GetComponent<Image>().fillAmount = fillValue;
    }

}
