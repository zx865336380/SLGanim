﻿//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaCombo : AttackSkill {
    
    public override void SetLevel(int level)
    {
        damageFactor = 5 + level * 5;
    }
    
}
