using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stage
{
    public class StageView : MonoBehaviour
    {
        /// <summary>
        /// •Ç‚Ìprefab
        /// </summary>
        [SerializeField]
        private GameObject _wallPrefab;

        public void Initialize()
        {

        }

        public void SetMap(int[,] mapList)
        {
            for (int i = 0; i < mapList.GetLength(0); i++)
            {
                for (int j = 0; j < mapList.GetLength(1); j++)
                {
                    if (mapList[i, j] == 0)
                    {
                        Instantiate(_wallPrefab, new Vector3(j, i, 0), Quaternion.identity);
                    }
                }
            }
        }
    }

}
