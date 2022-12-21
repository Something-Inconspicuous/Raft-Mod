using RaftModLoader;
﻿using UnityEngine;
using HMLLibrary;

public class Testytest : Mod{
    public void Start()
    {
        Debug.Log("Mod Testytest has been loaded!");
        
    }

    public void OnModUnload()
    {
        Debug.Log("Mod Testytest has been unloaded!");
    }
}