// ArchNet · Reverse Mask 2D Extension
// Darkens the whole UI with an overlay (the "masker") except the elements you highlight,
// which are drawn above it. Typical use: tutorials that point at one button.
// Docs: https://archnet-plateform.fr/#ReverseMask2DExtension

using System.Collections.Generic;
using UnityEngine;

namespace ArchNet.Extension
{
    [AddComponentMenu("ArchNet/Reverse Mask 2D Controller")]
    public class ReverseMaskController2D : MonoBehaviour
    {
        [Tooltip("Full-screen overlay shown behind the highlighted elements.")]
        [SerializeField] CanvasGroup _masker;

        readonly List<Mask2D> _highlighted = new List<Mask2D>();

        public IReadOnlyList<Mask2D> Highlighted => _highlighted;

        /// <summary>Shows the overlay and draws this element above it.</summary>
        public void Highlight(Mask2D mask)
        {
            if (mask == null) return;
            if (!_highlighted.Contains(mask)) _highlighted.Add(mask);
            mask.BringToFront();
            ShowMasker();
        }

        /// <summary>Puts the element back under the overlay; hides the overlay when nothing is left.</summary>
        public void Unhighlight(Mask2D mask)
        {
            if (mask == null || !_highlighted.Remove(mask)) return;
            mask.ResetSorting();
            if (_highlighted.Count == 0) HideMasker();
        }

        /// <summary>Removes every highlight and hides the overlay.</summary>
        public void Clear()
        {
            foreach (Mask2D mask in _highlighted)
            {
                if (mask != null) mask.ResetSorting();
            }
            _highlighted.Clear();
            HideMasker();
        }

        public void ShowMasker() => _masker.SetVisible(true);
        public void HideMasker() => _masker.SetVisible(false);
    }
}
