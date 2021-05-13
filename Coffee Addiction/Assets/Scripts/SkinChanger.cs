using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    private Animator animator; 
    [SerializeField] private RuntimeAnimatorController zombieSkin;
    [SerializeField] private RuntimeAnimatorController humanSkin;
    [SerializeField] private RuntimeAnimatorController smoke;
    [SerializeField] private PlayerHealth playerHealth;
    private bool isHuman = true;
    
    private void SetHumanSkin()
    {
        animator.runtimeAnimatorController = humanSkin;
    }
    
    private void SetZombieSkin()
    {
        animator.runtimeAnimatorController = zombieSkin;
    }
    
    private void Start()
    {
        playerHealth.OnHealthChange.AddListener(health =>
        {
            if (health <= 20 && isHuman)
            {
                isHuman = false;
                animator.runtimeAnimatorController = smoke;
                Invoke(nameof(SetZombieSkin), 1);
            }
            
            if (health > 20 && !isHuman)
            {
                isHuman = true;
                animator.runtimeAnimatorController = smoke;
                Invoke(nameof(SetHumanSkin), 1);
            }
        });
        animator = gameObject.GetComponent<Animator>();
    }
}
