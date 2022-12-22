using RaftModLoader;
﻿using UnityEngine;
using HMLLibrary;

public class Testytest : Mod{

    AssetBundle asset;

    public IEnumerator Start()
    {

        AssetBundleCreateRequest request = AssetBundle.LoadFromMemoryAsync(GetEmbeddedFileBytes("testingBundle.assets"));
        yield return request;
        asset = request.assetBundle;

        GameObject testingTable = asset.LoadAsset<GameObject>("table_and_chair");
        Instantiate(testingTable);


        Debug.Log("Mod Testytest has been loaded!");
        
    }

    public void OnModUnload()
    {
        asset.Unload(true);
        Debug.Log("Mod Testytest has been unloaded!");
    }

    [ConsoleCommand(name: "...", docs: "...")]
    public static void dotdotdot(string[] args){
        
        //...
        
    }

}