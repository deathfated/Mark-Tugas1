using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.ZombieTapie.Enemy
{
    public class ESoldierController : EnemyContoller
    {
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

        public override void OnEnemy()
        {
            LevelMan script = GameObject.FindObjectOfType<LevelMan>();
            script.ReduceLives(1);
        }

        public override void OnVillager()
        {
            //return;
        }

        protected override void Update()
        {
            CheckBounds();
            
            OnClicked();

            transform.position += MoveSpeed * Time.deltaTime * -transform.up;
        }
    }
}
