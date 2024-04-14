using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable enable

/// <summary>
///     Unity��Control�́A
///     Camera�̋������`���郂�f��
/// </summary>
public class BaseCameraModel : MonoBehaviour {

    // ==================================================
    // �v���p�e�B
    // ==================================================

    /// <summary>
    ///     X �ړ���
    /// </summary>
    [field: SerializeField]
    public float MoveQtyX { get; set; } = 0.001f;

    /// <summary>
    ///     Y �ړ���
    /// </summary>
    [field: SerializeField]
    public float MoveQtyY { get; set; } = 0.001f;

    // ==================================================
    // Public���\�b�h
    // ==================================================

    /// <summary>
    ///     ��Ɉړ�����
    /// </summary>
    public void MoveTop() {
        MoveMySelf(0, -MoveQtyY);
    }

    /// <summary>
    ///     ���Ɉړ�����
    /// </summary>
    public void MoveBottom() {
        MoveMySelf(0, MoveQtyY);
    }

    /// <summary>
    ///     �E�Ɉړ�����
    /// </summary>
    public void MoveRight() {
        MoveMySelf(-MoveQtyX, 0);
    }

    /// <summary>
    ///     ���Ɉړ�����
    /// </summary>
    public void MoveLeft() {
        MoveMySelf(MoveQtyX, 0);
    }

    /// <summary>
    ///     �E�΂ߏ�Ɉړ�����
    /// </summary>
    public void MoveTopRight() {
        MoveMySelf(-MoveQtyX, -MoveQtyY);
    }

    /// <summary>
    ///     ���΂ߏ�Ɉړ�����
    /// </summary>
    public void MoveTopLeft() {
        MoveMySelf(MoveQtyX, -MoveQtyY);
    }

    /// <summary>
    ///     �E�΂߉��Ɉړ�����
    /// </summary>
    public void MoveBottomRight() {
        MoveMySelf(-MoveQtyX, MoveQtyY);
    }

    /// <summary>
    ///     ���΂߉��Ɉړ�����
    /// </summary>
    public void MoveBottomLeft() {
        MoveMySelf(MoveQtyX, MoveQtyY);
    }


    // ==================================================
    // Private���\�b�h
    // ==================================================

    /// <summary>
    ///     ���g���ړ�����
    /// </summary>
    private void MoveMySelf(float x, float y) {

        this.gameObject.transform.position = new Vector3(
            this.gameObject.transform.position.x + x,
            this.gameObject.transform.position.y + y,
            this.gameObject.transform.position.z);
    }
}
