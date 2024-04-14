using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable enable

/// <summary>
///     UnityのControlの、
///     Cameraの挙動を定義するモデル
/// </summary>
public class BaseCameraModel : MonoBehaviour {

    // ==================================================
    // プロパティ
    // ==================================================

    /// <summary>
    ///     X 移動量
    /// </summary>
    [field: SerializeField]
    public float MoveQtyX { get; set; } = 0.001f;

    /// <summary>
    ///     Y 移動量
    /// </summary>
    [field: SerializeField]
    public float MoveQtyY { get; set; } = 0.001f;

    // ==================================================
    // Publicメソッド
    // ==================================================

    /// <summary>
    ///     上に移動する
    /// </summary>
    public void MoveTop() {
        MoveMySelf(0, -MoveQtyY);
    }

    /// <summary>
    ///     下に移動する
    /// </summary>
    public void MoveBottom() {
        MoveMySelf(0, MoveQtyY);
    }

    /// <summary>
    ///     右に移動する
    /// </summary>
    public void MoveRight() {
        MoveMySelf(-MoveQtyX, 0);
    }

    /// <summary>
    ///     左に移動する
    /// </summary>
    public void MoveLeft() {
        MoveMySelf(MoveQtyX, 0);
    }

    /// <summary>
    ///     右斜め上に移動する
    /// </summary>
    public void MoveTopRight() {
        MoveMySelf(-MoveQtyX, -MoveQtyY);
    }

    /// <summary>
    ///     左斜め上に移動する
    /// </summary>
    public void MoveTopLeft() {
        MoveMySelf(MoveQtyX, -MoveQtyY);
    }

    /// <summary>
    ///     右斜め下に移動する
    /// </summary>
    public void MoveBottomRight() {
        MoveMySelf(-MoveQtyX, MoveQtyY);
    }

    /// <summary>
    ///     左斜め下に移動する
    /// </summary>
    public void MoveBottomLeft() {
        MoveMySelf(MoveQtyX, MoveQtyY);
    }


    // ==================================================
    // Privateメソッド
    // ==================================================

    /// <summary>
    ///     自身を移動する
    /// </summary>
    private void MoveMySelf(float x, float y) {

        this.gameObject.transform.position = new Vector3(
            this.gameObject.transform.position.x + x,
            this.gameObject.transform.position.y + y,
            this.gameObject.transform.position.z);
    }
}
