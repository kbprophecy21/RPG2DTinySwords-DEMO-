using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovemenet();
    }




    void HandleMovemenet()
    {
        // Handle player movement logic here
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        transform.Translate(movement * Time.deltaTime);
    }

    void HandleJump()
    {
        // Handle player jump logic here
    }

    void HandleAttack()
    {
        // Handle player attack logic here
    }
}
