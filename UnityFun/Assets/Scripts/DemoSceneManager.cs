using TMPro;
using UnityEngine;
using System.Runtime.InteropServices;

public static class Fun {

#if !UNITY_EDITOR && (UNITY_IOS || UNITY_WEBGL)
    private const string dllName = "__Internal";
#else
    private const string dllName = "fun";
#endif

    [DllImport(dllName)]
    public static extern int fun_increment(int value);

    [DllImport(dllName)]
    public static extern int fun_decrement(int value);

}

public class DemoSceneManager : MonoBehaviour {
    
    public TextMeshProUGUI incrementLabel;
    public TextMeshProUGUI decrementLabel;

    private float _nextUpdate;

    private int _increment;
    private int _decrement = int.MaxValue;

    private void Update() {
        
        if (Time.time <= _nextUpdate) return;
        _nextUpdate = Time.time + 1.0f;

        _increment = Fun.fun_increment(_increment);
        incrementLabel.text = _increment.ToString();

        _decrement = Fun.fun_decrement(_decrement);
        decrementLabel.text = _decrement.ToString();

    }
}
