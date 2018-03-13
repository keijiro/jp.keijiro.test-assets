using UnityEditor;

namespace JP.Keijiro.TestAssets
{
    static class Selector
    {
        [MenuItem("Packages/Test Assets")]
        static void OpenPackageDirectory()
        {
            var path = "Packages/jp.keijiro.test-assets/README.md";
            Selection.activeObject = AssetDatabase.LoadMainAssetAtPath(path);
            EditorGUIUtility.PingObject(Selection.activeObject);
        }
    }
}
