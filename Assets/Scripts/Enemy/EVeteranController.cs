using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.ZombieTapie.Enemy
{
    public class EVeteranController : EnemyContoller
    {
        private float _currentShiftDelayL;
        private float _currentShiftDelayR;

        public override void OnEnemy()
        {
            LevelMan script = GameObject.FindObjectOfType<LevelMan>();
            script.ReduceLives(1);
        }

        public override void OnVillager()
        {
            
        }

        protected override void Update()
        {
            CheckBounds();
            
            OnClicked();
            
            transform.position += MoveSpeed * Time.deltaTime * -transform.up;

            _currentShiftDelayR -= Time.unscaledDeltaTime;

            if (_currentShiftDelayR <= 2f)
            {
                ShiftRight();
                _currentShiftDelayR = ShiftDelay;
            }

            _currentShiftDelayL -= Time.unscaledDeltaTime;

            if (_currentShiftDelayL <= 3f)
            {
                ShiftLeft();
                _currentShiftDelayL = ShiftDelay;
            }
        }

        private void Start()
        {
            _currentShiftDelayL = ShiftDelay;
            _currentShiftDelayR = ShiftDelay;
        }

        private void ShiftRight()
        {
            //for (int i = 0; i < 5; i++)
                transform.position += 0.1f * Random.Range(0f, 40f) * transform.right;
        }

        private void ShiftLeft()
        {
            //for (int i = 0; i < 10; i++)
                transform.position += 0.1f * Random.Range(0f, 40f) * -transform.right;
        }

        public override void OnClicked()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (hit.collider != null && hit.collider.CompareTag("Enemy"))
                {
                    PosReset();
                }
            }
        }
    }
}
