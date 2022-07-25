using FishNet.Object;
using FishNet.Object.Synchronizing;
using UnityEngine;

public class SyncVarDemoVars : NetworkBehaviour
{	

[field: SerializeField]
[field: SyncVar]
public string EntityString
  { get; set; }
  
[field: SerializeField]
[field: SyncVar]
public int EntityInt
  { get; set; }
  
[field: SerializeField]
[field: SyncVar]
public float EntityFloat
  { get; set; }  

[field: SerializeField]
[field: SyncVar]
public Vector2 EntityVector2
  { get; set; }  

[field: SerializeField]
[field: SyncVar]
public Vector3 EntityVector3
  { get; set; }  

 [field: SerializeField]
[field: SyncVar]
public Color EntityColor
  { get; set; }   
 
}
