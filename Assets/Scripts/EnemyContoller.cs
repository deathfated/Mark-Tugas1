using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContoller : MonoBehaviour
{
    public int Health = 1;
    public float MoveSpeed = 0.5f;

    private int _currentHealth;
    public Vector2 resetPosition;

    public bool isEnemy = true;

    private void OnEnable()
    {
        _currentHealth = Health;
        resetPosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
    }

    private void Update()
    {
        transform.position += -transform.up * MoveSpeed * Time.deltaTime;
    }

    public void ReduceEnemyHealth(int damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            if (other.gameObject.name == "Limit")
            {
                if (isEnemy == true)
                {
                    LevelMan script = GameObject.FindObjectOfType<LevelMan>();
                    script.ReduceLives(1);
                }

                gameObject.transform.position = resetPosition;
                gameObject.SetActive(false);

                Invoke("Activate", 10.0f);
            }
    }

    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void OnMouseDown()
    {
        if (isEnemy == false)
        {
            LevelMan script = GameObject.FindObjectOfType<LevelMan>();
            script.ReduceLives(5);
        }
        gameObject.transform.position = resetPosition;
        gameObject.SetActive(false);

        Invoke("Activate", 10.0f);
    }

}
