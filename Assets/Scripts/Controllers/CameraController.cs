using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable enable

/// <summary>
///     Cameraに対する入力を制御するコントローラー
/// </summary>
public class CameraController : MonoBehaviour {

    // ==================================================
    // プロパティ
    // ==================================================

    /// <summary>
    ///     制御対象のカメラ
    /// </summary>
    [field: SerializeField]
    public BaseCameraModel? ControlCamera { get; set; } = null;

    // ==================================================
    // Publicメソッド
    // ==================================================

    /// <summary>
    ///     入力キーに合わせてカメラを移動する
    /// </summary>
    public void MoveCamera() {

        // 操作対象カメラがnullなら操作しない
        if (ControlCamera is null) {
            return;
        }


        // Wキー: 上
        bool isTop = (Input.GetKey(KeyCode.W));
        // Aキー: 下
        bool isLeft = (Input.GetKey(KeyCode.A));
        // Dキー: 右
        bool isRight = (Input.GetKey(KeyCode.D));
        // Sキー: 下
        bool isBottom = (Input.GetKey(KeyCode.S));

        // 組み合わせキーの処理

        if (isTop && isLeft) {
            ControlCamera.MoveTopLeft();
            return;
        }

        if (isTop && isRight) {
            ControlCamera.MoveTopRight();
            return;
        }

        if (isBottom && isLeft) {
            ControlCamera.MoveBottomLeft();
            return;
        }

        if (isBottom && isRight) {
            ControlCamera.MoveBottomRight();
            return;
        }

        // 単一キーの処理

        if (isTop) {
            ControlCamera.MoveTop();
            return;
        }

        if (isBottom) {
            ControlCamera.MoveBottom();
            return;
        }

        if (isRight) {
            ControlCamera.MoveRight();
            return;
        }

        if (isLeft) {
            ControlCamera.MoveLeft();
            return;
        }
    }

    // ==================================================
    // Eventハンドラ
    // ==================================================

    /// <summary>
    ///     初回呼び出し時の処理
    /// </summary>
    public void Start() {
        
    }

    /// <summary>
    ///     毎秒呼び出される処理
    /// </summary>
    public void Update() {

        MoveCamera();
    }
}
