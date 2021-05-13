using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    private Animator animator; 
    [SerializeField] private RuntimeAnimatorController zombieSkin;
    [SerializeField] private RuntimeAnimatorController humanSkin;
    private PlayerHealth playerHealth;
    
    private void Start()
    {
        playerHealth = gameObject.GetComponent<PlayerHealth>();
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update() =>
        animator.runtimeAnimatorController = 
            playerHealth.currentHealth <= 20 ? zombieSkin : humanSkin;
    
}
