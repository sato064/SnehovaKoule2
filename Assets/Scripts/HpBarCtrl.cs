using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class HpBarCtrl: MonoBehaviour {

  Slider _slider;
  private float _hp;
  void Start () {
    // スライダーを取得する
    _slider = GameObject.Find("Slider").GetComponent<Slider>();
  }

  void Update () {
    // HP上昇
    _hp = HpControllerMaster.getHP1();


    // HPゲージに値を設定
    _slider.value = _hp;
  }
}