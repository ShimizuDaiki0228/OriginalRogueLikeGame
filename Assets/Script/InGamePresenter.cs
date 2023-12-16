using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace InGame
{
    public class InGamePresenter : MonoBehaviour
    {
        /// <summary>
        /// InGameView
        /// </summary>
        [SerializeField]
        private InGameView _view;

        /// <summary>
        /// InGameModel
        /// </summary>
        private InGameModel _model;

        private void Start()
        {
            _view.Initialize();
            _model = new InGameModel();

            Bind();
        }

        private void Bind()
        {
            _model.MapListProp
                .Subscribe(_view.SetMap)
                .AddTo(this);
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                _model.SetMap();
            }
        }
    }
}
