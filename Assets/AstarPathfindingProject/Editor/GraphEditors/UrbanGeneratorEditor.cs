using UnityEditor;
using Pathfinding;

[CustomGraphEditor(typeof(UrbanGenerator), "Urban Graph")]
public class PolarGeneratorEditor : GraphEditor
{
    // Here goes the GUI
    public override void OnInspectorGUI(NavGraph target)
    {
        var graph = target as UrbanGenerator;


    }
}