using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Character : ListableEntity
{
    public RuntimeAnimatorController animator;
    public AttackType attackType;

    public int level = 1;

    [SerializeField]
    public BaseAttributes baseAttributes;

    [SerializeField]
    public BaseAttributes bonusAttributes;

    public DerivedAttributes derivedAttributes;

    public abstract CharacterType characterType { get; }
}
