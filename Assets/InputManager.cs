using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Asset
{
    /// <summary>
    /// 入力補助
    /// </summary>
    class InputMng
    {
        public enum MouseButton
        {
            Left = 0,
            Right = 1,
            Middle = 2
        };

        public static bool IsDown()
        {
            return Input.GetMouseButtonDown((int)MouseButton.Left);
        }

        public static bool IsUp()
        {
            return Input.GetMouseButtonUp((int)MouseButton.Left);
        }

        public static Vector3 GetPosition()
        {
            return Input.mousePosition;
        }
    }
}
