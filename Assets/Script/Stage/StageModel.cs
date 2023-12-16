using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Stage
{
    public class StageModel
    {
        private int[,] _mapList;

        private readonly ReactiveProperty<int[,]> _mapListProp;
        public IReadOnlyReactiveProperty<int[,]> MapListProp => _mapListProp;

        private int _maxRoomSize = 10;

        public StageModel()
        {
            _mapListProp = new ReactiveProperty<int[,]>(new int[0, 0]);
        }

        /// <summary>
        /// É}ÉbÉvÇçÏê¨Ç∑ÇÈ
        /// </summary>
        public void SetMap()
        {
            _mapList = new int[_maxRoomSize, _maxRoomSize];

            for (int i = 0; i < _maxRoomSize; i++)
            {
                for (int j = 0; j < _maxRoomSize; j++)
                {
                    if (i == 0 || i == _maxRoomSize - 1 || j == 0 || j == _maxRoomSize - 1)
                    {
                        _mapList[i, j] = 0;
                    }
                    else
                    {
                        _mapList[i, j] = 1;
                    }
                }
            }

            _mapListProp.Value = _mapList;
        }
    }

}
