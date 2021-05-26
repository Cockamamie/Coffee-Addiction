using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeSpriteGenerator : MonoBehaviour
{
    private int spriteNumber;

    [SerializeField] private Sprite[] coffeeSprites;
    // Start is called before the first frame update
    private void Start()
    {
        spriteNumber = Random.Range(0, coffeeSprites.Length);
        GetComponent<SpriteRenderer>().sprite = coffeeSprites[spriteNumber];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
