using System.Collections;
using UnityEngine;

namespace Dz
{
    public class CharacterManager : MonoBehaviour
    {

        protected virtual void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        protected virtual void Update()
        {

        }
    }
}