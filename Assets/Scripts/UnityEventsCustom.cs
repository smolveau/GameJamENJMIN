using UnityEngine.Events;
using UnityEngine;

[System.Serializable]
public class UnityEventInt : UnityEvent<int> {}

[System.Serializable]
public class UnityEventBool : UnityEvent<bool> {}

[System.Serializable]
public class UnityEventFloat : UnityEvent<float> {}

[System.Serializable]
public class UnityEventVector2 : UnityEvent<Vector2> {}

[System.Serializable]
public class UnityEventDouble : UnityEvent<double> {}

[System.Serializable]
public class UnityEventChar : UnityEvent<char> {}

[System.Serializable]
public class UnityEventString : UnityEvent<string> {}

[System.Serializable]
public delegate void VoidDelegate();