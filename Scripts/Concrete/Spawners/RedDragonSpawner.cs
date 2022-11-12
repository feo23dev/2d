using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.ASpawners;
using UProje1.Controllers;
using UProje1.Pool;

namespace UProje1.Spawners
{
    public class RedDragonSpawner : BaseSpawner 
    {
        

    public override void Spawn()
    {
        RedDragonController enemy = RedDragonPool.Instance.Get();
        enemy.transform.position = transform.position;
        enemy.gameObject.SetActive(true);
    }
    }

}

