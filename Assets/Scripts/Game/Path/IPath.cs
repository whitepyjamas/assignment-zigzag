using UnityEngine;

namespace ZigZag.Game.Path
{
    public interface IPath
    {
        ITile Start();

        /// <summary>
        /// Move for  a relative amount.
        /// </summary>
        void Move(Vector2 movement);

        void Clear();
    }
}