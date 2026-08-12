using UnityEngine;
using Object = UnityEngine.Object;

namespace GoncaloMCOliveira.EssentialUtilities {
    
    public static class TransformExtensions {
        
        public static void DeleteChildren(this Transform transform) {
            foreach (Transform child in transform) {
                Object.Destroy(child.gameObject);
            }
        }
    }
}