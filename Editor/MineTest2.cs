using UnityEditor;
using UnityEngine;

public class MineTest2 : Editor
{
    [MenuItem("Tools/测试2", false, 0)]
    public static void Test()
    {
        Debug.Log("测试输出2");
    }
}
