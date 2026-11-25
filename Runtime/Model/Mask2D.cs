// ArchNet · Reverse Mask 2D Extension — highlightable element
// Put it on a UI element that ReverseMaskController2D can draw above the overlay.
// It adds its own Canvas and GraphicRaycaster when first highlighted, so it stays clickable.
// Docs: https://archnet-plateform.fr/#ReverseMask2DExtension

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ArchNet.Extension
{
    [RequireComponent(typeof(RectTransform))]
    [AddComponentMenu("ArchNet/Reverse Mask 2D")]
    public class Mask2D : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] Canvas _canvas;
        [Tooltip("Called when the highlighted element is clicked.")]
        [SerializeField] UnityEvent _onClick = new UnityEvent();

        public UnityEvent OnClick => _onClick;

        public Canvas Canvas
        {
            get
            {
                if (_canvas == null && !TryGetComponent(out _canvas)) _canvas = gameObject.AddComponent<Canvas>();
                if (!TryGetComponent(out GraphicRaycaster _)) gameObject.AddComponent<GraphicRaycaster>();
                return _canvas;
            }
        }

        public void BringToFront() => Canvas.BringToFront();
        public void ResetSorting() => Canvas.ResetSorting();

        public void OnPointerClick(PointerEventData eventData) => _onClick.Invoke();
    }
}
