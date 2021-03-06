﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public bool isTerrain = false;
    public bool isUnit = false;
    public bool isAnimated = false;
    public bool isMonster = false;
    public bool isFeralWolf = false;
    public bool isSettler = false;
    public bool isBuilding = false;
    public bool isResource = false;

    public bool isPlayer = false;
    public bool isSelected = false;

    public common.objects.UnityObjects unityObjects;

    public int id;

    public Dictionary<int, Unit> attackers = new Dictionary<int, Unit>();

    protected void Start()
    {
        unityObjects = new common.objects.UnityObjects(gameObject);
        id = Game.Manager.RegisterEntity(this);
    }

    internal void WithdrawAttacker(Unit attcker)
    {
        attackers.Remove(attcker.id);
    }

    public void GetAttacked(Unit attacker)
    {
        attackers.Add(attacker.id, attacker);
        attacker.StartAttack(this);
    }

    virtual internal void InteractWithSettler(Settler settler)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    protected void Update()
    {

    }

    
    
}
