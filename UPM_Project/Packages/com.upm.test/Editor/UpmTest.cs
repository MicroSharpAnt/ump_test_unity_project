using UnityEditor;
using UnityEngine;

public class UpmTest : Editor
{
    [MenuItem("Tools/测试", false, 0)]
    public static void Test()
    {
        Debug.Log("测试输出");
    }

    [MenuItem("Tools/更新测试", false, 0)]
    public static void Test2()
    {
        Debug.Log("测试输出_更新package");
    }
}