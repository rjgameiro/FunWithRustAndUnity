using TMPro;
using UnityEngine;

public class DemoSceneManager : MonoBehaviour {
    
    public TextMeshProUGUI incrementLabel;
    public TextMeshProUGUI decrementLabel;

    private float _nextUpdate;

    private int _increment;
    private int _decrement = int.MaxValue;

    private void Update() {
        
        if (Time.time <= _nextUpdate) return;
        _nextUpdate = Time.time + 1.0f;

        _increment++;
        incrementLabel.text = _increment.ToString();
        
        _decrement--;
        decrementLabel.text = _decrement.ToString();

    }
}
