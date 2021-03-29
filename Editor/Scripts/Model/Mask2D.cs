using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ArchNet.Extension.ReverseMask2D
{
    /// <summary>
    /// [EXTENSION] - [ARCH NET] - [REVERSE MASK 2D] Mask 2D Model for Reverse Mask 2D Extension
    /// author : LOUIS PAKEL
    /// </summary>
    public class Mask2D : MonoBehaviour, IPointerClickHandler
    {
        #region Serialized Fields 

        [SerializeField] private Canvas _canvas;

        #endregion

        #region Private Fields

        private int _id;

        #endregion

        #region Getter

        /// <summary>
        /// Description : get canvas
        /// </summary>
        public Canvas GetCanvas()
        {
            return _canvas;
        }

        public int GetId()
        {
            return _id;
        }


        #endregion

        #region Public Methods

        /// <summary>
        /// Description : Set Canvas position in foreground
        /// </summary>
        public void ToForeground()
        {
            if (IsInit() == false)
            {
                InitMask();
            }

            CanvasExtension.SetCanvasToForeground(_canvas);
        }

        /// <summary>
        /// Description : Reset Canvas position
        /// </summary>
        public void ResetCanvas()
        {
            if (IsInit() == false)
            {
                InitMask();
            }

            CanvasExtension.StopOverridingCanvas(_canvas);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Description : Init Mask
        /// </summary>
        public void InitMask()
        {
            if (GetComponent<Canvas>() == null)
            {
                gameObject.AddComponent<Canvas>();
            }

            if (GetComponent<GraphicRaycaster>() == null)
            {
                gameObject.AddComponent<GraphicRaycaster>();
            }

            if (_canvas == null)
            {
                _canvas = GetComponent<Canvas>();
            }
        }

        /// <summary>
        /// Description : Check if the mask is init
        /// </summary>
        /// <returns></returns>
        private bool IsInit()
        {
            bool lResult = true;

            if (GetComponent<Canvas>() == null)
            {
                lResult = false;
            }

            if (GetComponent<GraphicRaycaster>() == null)
            {
                lResult = false;
            }

            return lResult;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            // DO SOMETHING
        }

        #endregion
    }
}