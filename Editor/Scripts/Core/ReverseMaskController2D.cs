using System.Collections.Generic;
using UnityEngine;

namespace ArchNet.Extension.ReverseMask2D
{
    /// <summary>
    /// [EXTENSION] - [ARCH NET] - [REVERSE MASK 2D] Reverse Mask 2D Extension Controller
    /// author : LOUIS PAKEL
    /// </summary>
    public class ReverseMaskController2D : MonoBehaviour
    {
        #region Serialized Fields 

        [Header("MASKER")]
        [SerializeField] private RectTransform _background;
        [SerializeField] private CanvasGroup _masker;


        #endregion

        #region Private Fields

        private List<Mask2D> _masks = new List<Mask2D>();

        #endregion

        #region Public  Methods


        #region CRUD Mask
        /// <summary>
        /// Description : add mask 
        /// </summary>
        /// <param name="pMask"></param>
        public void AddMask(Mask2D pMask)
        {
            if (_masks.Count == 0)
            {
                _masks.Add(pMask);
            }
            if (false == IsInList(pMask))
            {
                _masks.Add(pMask);
            }
        }

        /// <summary>
        /// Description : remove mask
        /// </summary>
        /// <param name="pMask"></param>
        public void RemoveMask(Mask2D pMask)
        {
            if (true == IsInList(pMask))
            {
                _masks.Remove(pMask);
            }
        }

        /// <summary>
        /// Description : Check if a mask in already in the list
        /// </summary>
        /// <param name="pMask"></param>
        /// <returns></returns>
        public bool IsInList(Mask2D pMask)
        {
            bool lResult = false;

            foreach (Mask2D lMask in _masks)
            {
                if (lMask.GetId() == pMask.GetId())
                {
                    lResult = true;
                }
            }

            return lResult;
        }

        #endregion


        #region Getter

        /// <summary>
        /// Description : return mask from the list
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Mask2D GetMask(int pId)
        {
            Mask2D lResult = null;

            foreach (Mask2D lMask in _masks)
            {
                if (lMask.GetId() == pId)
                {
                    lResult = lMask;
                }
            }

            return lResult;
        }


        /// <summary>
        /// Description : Hide masker
        /// </summary>
        public void HideMasker()
        {
            GetMasker().alpha = 0f;
            GetMasker().interactable = false;
            GetMasker().blocksRaycasts = false;
        }

        /// <summary>
        /// Description : Show masker
        /// </summary>
        public void ShowMasker()
        {
            GetMasker().alpha = 1f;
            GetMasker().interactable = true;
            GetMasker().blocksRaycasts = true;
        }

        /// <summary>
        /// Description : retrun masker
        /// </summary>
        /// <returns></returns>
        private CanvasGroup GetMasker()
        {
            return _masker;
        }
        #endregion



        #endregion

        #region Private Methods

        #endregion
    }
}
