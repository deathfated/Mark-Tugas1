using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.ZombieTapie.Enemy
{
    public class EVillagerController : EnemyContoller
    {
        public override void OnClicked()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (hit.collider != null && hit.collider.CompareTag("Villager"))
                {

                    OnVillager();

                    PosReset();
                }
            }
        }

        public override void OnEnemy()
        {
            
        }

        public override void OnVillager()
        {

            LevelMan script = GameObject.FindObjectOfType<LevelMan>();
            script.ReduceLives(5);
        }

        protected override void Update()
        {
            CheckBounds();
            
            OnClicked();

            transform.position += MoveSpeed * Time.deltaTime * -transform.up;
        }

    }
}
