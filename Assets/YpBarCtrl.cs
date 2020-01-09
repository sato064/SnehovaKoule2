using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class YpBarCtrl: MonoBehaviour {

  Slider _slider;
  Slider _slider2;
  private float _hp;
  private float _hp2;
  void Start () {
    // スライダーを取得する
    _slider = GameObject.Find("YSlider").GetComponent<Slider>();
    _slider2 = GameObject.Find("YSlider2").GetComponent<Slider>();
  }

  void Update () {
    // HP上昇
    _hp = YpControllerMaster.getYP1();
    _hp2 = YpControllerMaster.getYP2();



    // HPゲージに値を設定
    _slider.value = _hp;
    _slider2.value = _hp2;
  }
}