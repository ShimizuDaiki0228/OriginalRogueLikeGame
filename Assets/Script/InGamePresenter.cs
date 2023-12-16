using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using Stage;

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

        /// <summary>
        /// Stage
        /// </summary>
        [SerializeField]
        private StagePresenter _stage;

        private void Start()
        {
            _view.Initialize();
            _model = new InGameModel();

            _stage.Initialize();

            Bind();
        }

        private void Bind()
        {
            
        }

        private void Update()
        {
            float deltaTime = Time.deltaTime;

            _stage.ManualUpdate(deltaTime);
        }
    }
}
