using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Character : ScriptableObject
{
    public Sprite avatar;
    public RuntimeAnimatorController animator;
    public AttackType attack;

    public int level = 1;

    [SerializeField]
    public BaseAttributes baseAttributes;

    [SerializeField]
    public BaseAttributes bonusAttributes;

    public DerivedAttributes derivedAttributes;

    public abstract CharacterType type { get; }
}
