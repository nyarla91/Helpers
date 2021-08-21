using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Controls
{
    private static Lazy<InputMap> _map = new Lazy<InputMap>();
    public static InputMap Map => _map.Value;
}
