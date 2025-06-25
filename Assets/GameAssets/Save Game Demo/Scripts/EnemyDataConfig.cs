using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveGameDemo
{
    [CreateAssetMenu(fileName = "EnemyDataConfig", menuName = "Scriptable Object/Enemy Data Config", order = 1)]
    public class EnemyDataConfig : ScriptableObject
    {
        public string id;
        public float health;
        public Sprite sprIcon;
    }
}
