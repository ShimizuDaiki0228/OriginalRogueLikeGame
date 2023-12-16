using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Stage
{
    public class StagePresenter : MonoBehaviour
    {
        /// <summary>
        /// StageView
        /// </summary>
        [SerializeField]
        private StageView _view;

        /// <summary>
        /// StageModel
        /// </summary>
        private StageModel _model;

        /// <summary>
        /// èâä˙âª
        /// </summary>
        public void Initialize()
        {
            _view.Initialize();
            _model = new StageModel();

            Bind();
        }

        private void Bind()
        {
            _model.MapListProp
                .Subscribe(_view.SetMap)
                .AddTo(this);
        }

        /// <summary>
        /// éËìÆUpdate
        /// </summary>
        public void ManualUpdate(float deltaTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _model.SetMap();
            }
        }
    }

}
