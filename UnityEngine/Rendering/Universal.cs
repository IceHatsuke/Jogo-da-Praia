using System;

namespace UnityEngine.Rendering
{
    internal class Universal
    {
        internal class UniversalAdditionalCameraData
        {
            internal bool renderShadows;
            internal object requiresColorOption;
            internal object requiresDepthOption;

            internal void SetRenderer(int v)
            {
                throw new NotImplementedException();
            }

            public static explicit operator UniversalAdditionalCameraData(Component v)
            {
                throw new NotImplementedException();
            }
        }
    }
}