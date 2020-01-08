using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class HpBarCtrl1: MonoBehaviour {

  Slider _slider;
  private float _hp;
  void Start () {
    // スライダーを取得する
    _slider = GameObject.Find("Slider2").GetComponent<Slider>();
  }

  void Update () {
    // HP上昇
    _hp = HpControllerMaster.getHP2();


    // HPゲージに値を設定
    _slider.value = _hp;
  }
}