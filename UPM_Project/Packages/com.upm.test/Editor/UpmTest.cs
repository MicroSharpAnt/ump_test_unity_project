using UnityEditor;
using UnityEngine;

public class UpmTest : Editor
{
    [MenuItem("Tools/测试", false, 0)]
    public static void Test()
    {
        Debug.Log("测试输出");
    }
}