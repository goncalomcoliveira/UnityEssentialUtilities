using UnityEngine;

namespace GoncaloMCOliveira.EssentialUtilities {
    
    public static class CanvasUtils {
        
        public static Vector3 GetWorldPosition(
            RectTransform element,
            Camera camera = null)
        {
            if (camera == null)
                camera = CameraUtils.Main;

            RectTransformUtility.ScreenPointToWorldPointInRectangle(
                element,
                element.position,
                camera,
                out var result
            );

            return result;
        }
    }
}