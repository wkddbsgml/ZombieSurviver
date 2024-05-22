using UnityEngine;

// 게임 점수를 증가시키는 아이템
public class Coin : MonoBehaviour, IItem {
    public int score = 200; // 증가할 점수

    public void Use(GameObject target) {
    }
}