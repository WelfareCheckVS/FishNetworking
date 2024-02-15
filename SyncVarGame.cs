
using FishNet.CodeGenerating;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using UnityEngine;

public class SyncVarGame : NetworkBehaviour
{
[AllowMutableSyncType]
public SyncVar<string> ID = new();
[AllowMutableSyncType]
public SyncVar<string> Name = new();
[AllowMutableSyncType]
public SyncVar<string> Guild = new();
[AllowMutableSyncType]
public SyncVar<string> Parent = new();
[AllowMutableSyncType]
public SyncVar<string> Type = new();
[AllowMutableSyncType]
public SyncVar<string> SubType = new();
[AllowMutableSyncType]
public SyncVar<float> HP = new();
[AllowMutableSyncType]
public SyncVar<float> HPMax = new();
[AllowMutableSyncType]
public SyncVar<float> MP = new();
[AllowMutableSyncType]
public SyncVar<float> MPMax = new();
[AllowMutableSyncType]
public SyncVar<float> Level = new();
[AllowMutableSyncType]
public SyncVar<float> XP = new();
[AllowMutableSyncType]
public SyncVar<float> MagicAttack = new();
[AllowMutableSyncType]
public SyncVar<float> MagicDefense = new();
[AllowMutableSyncType]
public SyncVar<float> PhysicalAttack = new();
[AllowMutableSyncType]
public SyncVar<float> PhysicalDefense = new();
[AllowMutableSyncType]
public SyncVar<Vector3> AstarClientDestination = new();
[AllowMutableSyncType]
public SyncVar<Vector3> AstarDestination = new();
[AllowMutableSyncType]
public SyncVar<Vector3> AstarPosition = new();
[AllowMutableSyncType]
public SyncVar<float> AstarAggroDistance = new();
[AllowMutableSyncType]
public SyncVar<float> AstarAttackDistance = new();
[AllowMutableSyncType]
public SyncVar<float> AstarEndDistance = new();
[AllowMutableSyncType]
public SyncVar<float> AstarSpeed = new();
[AllowMutableSyncType]
public SyncVar<Vector3> CurrentPosition = new();
[AllowMutableSyncType]
public SyncVar<Vector3> EndPosition = new();
[AllowMutableSyncType]
public SyncVar<float> Amount = new();
[AllowMutableSyncType]
public SyncVar<float> AmountMax = new();
[AllowMutableSyncType]
public SyncVar<float> GameTime = new();
[AllowMutableSyncType]
public SyncVar<GameObject> Obj1 = new();
[AllowMutableSyncType]
public SyncVar<GameObject> Obj2 = new();
[AllowMutableSyncType]
public SyncVar<GameObject> Obj3 = new();
[AllowMutableSyncType]
public SyncVar<bool> Aggressive = new();
[AllowMutableSyncType]
public SyncVar<bool> AstarReturnHome = new();
[AllowMutableSyncType]
public SyncVar<bool> Attacking = new();
[AllowMutableSyncType]
public SyncVar<bool> Building = new();
[AllowMutableSyncType]
public SyncVar<bool> Chatting = new();
[AllowMutableSyncType]
public SyncVar<bool> Combat = new();
[AllowMutableSyncType]
public SyncVar<bool> Dead = new();
[AllowMutableSyncType]
public SyncVar<bool> Despawning = new();
[AllowMutableSyncType]
public SyncVar<bool> Harvesting = new();
[AllowMutableSyncType]
public SyncVar<bool> Immune = new();
[AllowMutableSyncType]
public SyncVar<bool> Moving = new();
[AllowMutableSyncType]
public SyncVar<bool> Ready = new();
[AllowMutableSyncType]
public SyncVar<bool> TakingAction = new();
[AllowMutableSyncType]
public SyncVar<bool> Visible = new();
[AllowMutableSyncType]
public SyncVar<Color> Color = new();


public void Set_ID(string Val)
{
    ID.Value = Val;
}
public void Set_Name(string Val)
{
    Name.Value = Val;
}
public void Set_Guild(string Val)
{
    Guild.Value = Val;
}
public void Set_Parent(string Val)
{
    Parent.Value = Val;
}
public void Set_Type(string Val)
{
    Type.Value = Val;
}
public void Set_SubType(string Val)
{
    SubType.Value = Val;
}
public void Set_HP(float Val)
{
    HP.Value = Val;
}
public void Set_HPMax(float Val)
{
    HPMax.Value = Val;
}
public void Set_MP(float Val)
{
    MP.Value = Val;
}
public void Set_MPMax(float Val)
{
    MPMax.Value = Val;
}
public void Set_Level(float Val)
{
    Level.Value = Val;
}
public void Set_XP(float Val)
{
    XP.Value = Val;
}
public void Set_MagicAttack(float Val)
{
    MagicAttack.Value = Val;
}
public void Set_MagicDefense(float Val)
{
    MagicDefense.Value = Val;
}
public void Set_PhysicalAttack(float Val)
{
    PhysicalAttack.Value = Val;
}
public void Set_PhysicalDefense(float Val)
{
    PhysicalDefense.Value = Val;
}
public void Set_AstarClientDestination(Vector3 Val)
{
    AstarClientDestination.Value = Val;
}
public void Set_AstarDestination(Vector3 Val)
{
    AstarDestination.Value = Val;
}
public void Set_AstarPosition(Vector3 Val)
{
    AstarPosition.Value = Val;
}
public void Set_AstarAggroDistance(float Val)
{
    AstarAggroDistance.Value = Val;
}
public void Set_AstarAttackDistance(float Val)
{
    AstarAttackDistance.Value = Val;
}
public void Set_AstarEndDistance(float Val)
{
    AstarEndDistance.Value = Val;
}
public void Set_AstarSpeed(float Val)
{
    AstarSpeed.Value = Val;
}
public void Set_CurrentPosition(Vector3 Val)
{
    CurrentPosition.Value = Val;
}
public void Set_EndPosition(Vector3 Val)
{
    EndPosition.Value = Val;
}
public void Set_Amount(float Val)
{
    Amount.Value = Val;
}
public void Set_AmountMax(float Val)
{
    AmountMax.Value = Val;
}
public void Set_GameTime(float Val)
{
    GameTime.Value = Val;
}
public void Set_Obj1(GameObject Val)
{
    Obj1.Value = Val;
}
public void Set_Obj2(GameObject Val)
{
    Obj2.Value = Val;
}
public void Set_Obj3(GameObject Val)
{
    Obj3.Value = Val;
}
public void Set_Aggressive(bool Val)
{
    Aggressive.Value = Val;
}
public void Set_AstarReturnHome(bool Val)
{
    AstarReturnHome.Value = Val;
}
public void Set_Attacking(bool Val)
{
    Attacking.Value = Val;
}
public void Set_Building(bool Val)
{
    Building.Value = Val;
}
public void Set_Chatting(bool Val)
{
    Chatting.Value = Val;
}
public void Set_Combat(bool Val)
{
    Combat.Value = Val;
}
public void Set_Dead(bool Val)
{
    Dead.Value = Val;
}
public void Set_Despawning(bool Val)
{
    Despawning.Value = Val;
}
public void Set_Harvesting(bool Val)
{
    Harvesting.Value = Val;
}
public void Set_Immune(bool Val)
{
    Immune.Value = Val;
}
public void Set_Moving(bool Val)
{
    Moving.Value = Val;
}
public void Set_Ready(bool Val)
{
    Ready.Value = Val;
}
public void Set_TakingAction(bool Val)
{
    TakingAction.Value = Val;
}
public void Set_Visible(bool Val)
{
    Visible.Value = Val;
}
public void Set_Color(Color Val)
{
    Color.Value = Val;
}

public string Get_ID()
{
    return ID.Value;
}
public string Get_Name()
{
    return Name.Value;
}
public string Get_Guild()
{
    return Guild.Value;
}
public string Get_Parent()
{
    return Parent.Value;
}
public string Get_Type()
{
    return Type.Value;
}
public string Get_SubType()
{
    return SubType.Value;
}
public float Get_HP()
{
    return HP.Value;
}
public float Get_HPMax()
{
    return HPMax.Value;
}
public float Get_MP()
{
    return MP.Value;
}
public float Get_MPMax()
{
    return MPMax.Value;
}
public float Get_Level()
{
    return Level.Value;
}
public float Get_XP()
{
    return XP.Value;
}
public float Get_MagicAttack()
{
    return MagicAttack.Value;
}
public float Get_MagicDefense()
{
    return MagicDefense.Value;
}
public float Get_PhysicalAttack()
{
    return PhysicalAttack.Value;
}
public float Get_PhysicalDefense()
{
    return PhysicalDefense.Value;
}
public Vector3 Get_AstarClientDestination()
{
    return AstarClientDestination.Value;
}
public Vector3 Get_AstarDestination()
{
    return AstarDestination.Value;
}
public Vector3 Get_AstarPosition()
{
    return AstarPosition.Value;
}
public float Get_AstarAggroDistance()
{
    return AstarAggroDistance.Value;
}
public float Get_AstarAttackDistance()
{
    return AstarAttackDistance.Value;
}
public float Get_AstarEndDistance()
{
    return AstarEndDistance.Value;
}
public float Get_AstarSpeed()
{
    return AstarSpeed.Value;
}
public Vector3 Get_CurrentPosition()
{
    return CurrentPosition.Value;
}
public Vector3 Get_EndPosition()
{
    return EndPosition.Value;
}
public float Get_Amount()
{
    return Amount.Value;
}
public float Get_AmountMax()
{
    return AmountMax.Value;
}
public float Get_GameTime()
{
    return GameTime.Value;
}
public GameObject Get_Obj1()
{
    return Obj1.Value;
}
public GameObject Get_Obj2()
{
    return Obj2.Value;
}
public GameObject Get_Obj3()
{
    return Obj3.Value;
}
public bool Get_Aggressive()
{
    return Aggressive.Value;
}
public bool Get_AstarReturnHome()
{
    return AstarReturnHome.Value;
}
public bool Get_Attacking()
{
    return Attacking.Value;
}
public bool Get_Building()
{
    return Building.Value;
}
public bool Get_Chatting()
{
    return Chatting.Value;
}
public bool Get_Combat()
{
    return Combat.Value;
}
public bool Get_Dead()
{
    return Dead.Value;
}
public bool Get_Despawning()
{
    return Despawning.Value;
}
public bool Get_Harvesting()
{
    return Harvesting.Value;
}
public bool Get_Immune()
{
    return Immune.Value;
}
public bool Get_Moving()
{
    return Moving.Value;
}
public bool Get_Ready()
{
    return Ready.Value;
}
public bool Get_TakingAction()
{
    return TakingAction.Value;
}
public bool Get_Visible()
{
    return Visible.Value;
}
public Color Get_Color()
{
    return Color.Value;
}

}
