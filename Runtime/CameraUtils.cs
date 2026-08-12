using UnityEngine;

namespace GoncaloMCOliveira.EssentialUtilities {
    
    public static class CameraUtils {
        
        /*
         * When calling camera.main, Unity searches all the objects for the main camera tag.
         * This section removes the need for that expensive search by storing a static reference
         * and providing it.
         */
        private static Camera _mainCamera;

        /** Provides a static reference to the main camera. */
        public static Camera Main {
            get {
                if (_mainCamera == null)
                    _mainCamera = Camera.main;

                return _mainCamera;
            }
        }

        /** Clears cached reference to the camera. */
        public static void ClearCache() {
            _mainCamera = null;
        }
    }
}