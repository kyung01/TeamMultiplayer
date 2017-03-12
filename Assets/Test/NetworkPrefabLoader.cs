﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkPrefabLoader : NetworkBehaviour
{
    [ClientRpc]
    public void RpcLoadPrefab_INDEPENDENT(PREFAB_ID id, GameData.TEAM team)
    {
        var t = PrefabBank.SPAWN(id, team);
        if (t == null) return;
        //t.transform.parent = this.transform;
        t.transform.position = this.transform.position;
        t.transform.rotation = this.transform.rotation;
    }
    [ClientRpc]
    public void RpcLoadPrefab_ParentMe(PREFAB_ID id, GameData.TEAM team)
    {
        var t = PrefabBank.SPAWN(id, team);
        if (t == null) return;
        t.transform.parent = this.transform;
        t.transform.position = this.transform.position;
        t.transform.rotation = this.transform.rotation;
    }

}