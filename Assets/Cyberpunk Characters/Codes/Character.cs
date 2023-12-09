using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public static float Damage
    {
        get { return GameManager.instance.playerId == 0 ? 1.1f : 1f; } //첫번째 플레이어면 대미지 1.1배 증가
    }
    public static float Speed
    {
        get { return GameManager.instance.playerId == 1? 1.2f : 1f; } //두번째 플레이어면 스피드 1.1배속
    }

    public static int Count
    {
        get { return GameManager.instance.playerId == 2 ? 1 : 0; }
    }

    /*
    public static float WeaponSpeed
    {
        get { return GameManager.instance.playerId == 2 ? 1.1f : 1f; } //세번째 플레이어면 연사력 1.1배 증가
    }
    public static float WeaponRate
    {
        get { return GameManager.instance.playerId == 2 ? 0.9f : 1f; } //세번째 플레이어면 연사력 1.1배 증가
    }*/
}
