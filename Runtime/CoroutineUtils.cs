using System.Collections.Generic;
using UnityEngine;

namespace GoncaloMCOliveira.EssentialUtilities {
    
    public static class CoroutineUtils {
        
        /*
         * Everytime you create a new WaitForSeconds, you create excessive garbage that the
         * garbage cleaner has to clean up.
         * By caching these objects, we can reduce this garbage collection operation.
         */
        private static readonly Dictionary<float, WaitForSeconds> WaitCache = new();

        /** Provides WaitForSeconds caching and retrieval. */
        public static WaitForSeconds WaitForSeconds(float seconds) {
            
            if (WaitCache.TryGetValue(seconds, out WaitForSeconds wait))
                return wait;

            wait = new WaitForSeconds(seconds);
            WaitCache[seconds] = wait;

            return wait;
        }
        
        /** Clears WaitForSeconds cache. */
        public static void ClearWaitCache() {
            WaitCache.Clear();
        }
    }
}