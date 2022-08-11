using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.ZombieTapie.Enemy
{
    public abstract class EnemyContoller : MonoBehaviour, IClick, IEnemyType
    {
        [SerializeField] protected int Health = 1;
        [SerializeField] protected float MoveSpeed;
        [SerializeField] protected float ShiftDelay;

        private int _currentHealth;
        private Vector2 resetPosition;

        protected virtual void OnEnable()
        {
            _currentHealth = Health;
            resetPosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        }

        protected abstract void Update();


        protected virtual void ReduceEnemyHealth(int damage)
        {
            _currentHealth -= damage;

            if (_currentHealth <= 0)
            {
                _currentHealth = 0;
                gameObject.SetActive(false);
            }
        }

        /*protected virtual void CheckBounds()
        {
            if(gameObject.transform.position.y <= -5)
            {
                OnEnemy();

                gameObject.transform.position = resetPosition;
                gameObject.SetActive(false);

                Invoke(nameof(Activate), 10.0f);
            }
        }*/

        protected virtual void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.name == "Limit")
            {
                OnEnemy();

                gameObject.transform.position = resetPosition;
                gameObject.SetActive(false);

                Invoke(nameof(Activate), 10.0f);
            }
        }

        /*protected virtual void OnTriggerEnter2D(Collider2D other);
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
        }*/

        public abstract void OnEnemy();
        public abstract void OnVillager();
        public abstract void OnClicked();

        protected virtual void PosReset()
        {
            gameObject.transform.position = resetPosition;
            gameObject.SetActive(false);

            Invoke(nameof(Activate), 10.0f);
        }

        protected virtual void Activate()
        {
            gameObject.SetActive(true);
        }

        /*protected virtual void OnMouseDown()
        {
            if (isEnemy == false)
            {
                LevelMan script = GameObject.FindObjectOfType<LevelMan>();
                script.ReduceLives(5);
            }

            OnClicked();

            OnVillager();

            gameObject.transform.position = resetPosition;
            gameObject.SetActive(false);

            Invoke("Activate", 10.0f);
        }*/
    }
}
