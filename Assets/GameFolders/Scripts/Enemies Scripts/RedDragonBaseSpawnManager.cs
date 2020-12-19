using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject1.Controllers;

namespace UdemyProject1.Spawners
{
    public abstract class RedDragonBaseSpawnManager :MonoBehaviour
    {
        protected float minSpawnTime=1f;

        protected float maxSpawnTime=2f;

        private float passedTime, spawnTime;

        protected void AdjustSpawnTime()
        {
            spawnTime = UnityEngine.Random.Range(minSpawnTime, maxSpawnTime);
        }

        protected void IncremetPassedTime()
        {
            passedTime += Time.deltaTime;
        }

        protected void Spawn(RedDragonManager redDragon)
        {
            if (passedTime > spawnTime )
            {
                redDragon = RedDragonPoolManager.Instance.GetPoolObject();
                redDragon.transform.position = this.transform.position;
                redDragon.gameObject.SetActive(true);
                passedTime = 0f;
                AdjustSpawnTime();
            }
        }
    }
}
