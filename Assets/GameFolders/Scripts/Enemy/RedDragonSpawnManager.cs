using UnityEngine;
using UdemyProject1.Controllers;

namespace UdemyProject1.Spawners
{
    public class RedDragonSpawnManager : RedDragonBaseSpawnManager
    {
        private RedDragonManager redDragon;

        [SerializeField]
        [Range(1f, 2f)]
        float MinSpawnTime;

        [SerializeField]
        [Range(2f, 5f)]
        float MaxSpawnTime;

        private void Start()
        {
            AdjustSpawnTime();
            minSpawnTime = MinSpawnTime;
            maxSpawnTime = MaxSpawnTime;
        }

        private void Update()
        {
            IncremetPassedTime();
            Spawn(redDragon);
        }
    }
}
