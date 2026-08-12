using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GoncaloMCOliveira.EssentialUtilities {
    
    public static class UIUtils {
        
        private static readonly List<RaycastResult> RaycastResults = new();

        /** Returns whether the mouse pointer is over a UI element or not. */
        public static bool IsPointerOverUI() {
            if (EventSystem.current == null)
                return false;

            var eventData = new PointerEventData(EventSystem.current) {
                position = Input.mousePosition
            };

            RaycastResults.Clear();

            EventSystem.current.RaycastAll(eventData, RaycastResults);

            return RaycastResults.Count > 0;
        }
    }
}