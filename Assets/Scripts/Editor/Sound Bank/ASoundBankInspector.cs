using UnityEngine;
using Minesweeper.Audio;

namespace Minesweeper.Editor
{
    public abstract class ASoundBankInspector<T, E> : UnityEditor.Editor 
        where T : ASoundBank<E>
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            T instance = target as T;

            GUILayout.Space(10f);
        }

        protected abstract void DrawButton(T instance);
    }
}
