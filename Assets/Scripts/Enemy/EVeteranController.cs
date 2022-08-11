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
            OnClicked();
            
            transform.position += MoveSpeed * Time.deltaTime * -transform.up;

            _currentShiftDelayR -= Time.unscaledDeltaTime;

            if (_currentShiftDelayR <= 3f)
            {
                ShiftRight();
                _currentShiftDelayR = ShiftDelay;
            }

            _currentShiftDelayL -= Time.unscaledDeltaTime;

            if (_currentShiftDelayL <= 2f)
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
            transform.position += transform.right * MoveSpeed;
        }

        private void ShiftLeft()
        {
            transform.position += -transform.right * MoveSpeed;
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
