using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using Pathfinding.Serialization;
using Pathfinding.Util;
using Pathfinding.Serialization.JsonFx;
using System;
using Curves;

// Inherit our new graph from the base graph type
[JsonOptIn]
public class UrbanGenerator : NavGraph
{
    public Vector3 center = Vector3.zero;

    // Here we will store all nodes in the graph
    PointNode[] nodes;
    

    BezierSpline[] roads;

    public override void GetNodes(GraphNodeDelegateCancelable del)
    {
        throw new NotImplementedException();
    }

    public override void ScanInternal(OnScanStatus statusCallback)
    {
        roads = GameObject.FindObjectsOfType<BezierSpline>();

        throw new NotImplementedException();
    }

    // Create a single node at the specified position
    PointNode CreateNode(Vector3 position)
    {
        var node = new PointNode(active);
        // Node positions are stored as Int3. We can convert a Vector3 to an Int3 like this
        node.position = (Int3)position;
        return node;
    }
}