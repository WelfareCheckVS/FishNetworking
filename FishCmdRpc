using UnityEngine;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using System.Collections;
using Unity.VisualScripting;

public class FishCmdRpc : NetworkBehaviour
{
	
	[ObserversRpc] // RPC - Master
    public void RpcMaster(string Trigger, string ReturnTrigger, GameObject TargetObject, GameObject[] ObjectArray, Vector2[] PositionArray, string[] StringArray, int[] IntArray, float[] FloatArray, Color[] ColorArray)
    {
        CustomEvent.Trigger(gameObject, Trigger, TargetObject, ReturnTrigger, ObjectArray, PositionArray, StringArray, IntArray, FloatArray, ColorArray);
    }

	[ServerRpc] // Cmd - Master
    public void CmdMaster(string Trigger, string ReturnTrigger, GameObject TargetObject, GameObject[] ObjectArray, Vector2[] PositionArray, string[] StringArray, int[] IntArray, float[] FloatArray, Color[] ColorArray)
    {
        CustomEvent.Trigger(gameObject, Trigger, TargetObject, ReturnTrigger, ObjectArray, PositionArray, StringArray, IntArray, FloatArray, ColorArray);
    }
	
}
