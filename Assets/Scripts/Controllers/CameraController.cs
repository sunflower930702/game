using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable enable

/// <summary>
///     Camera�ɑ΂�����͂𐧌䂷��R���g���[���[
/// </summary>
public class CameraController : MonoBehaviour {

    // ==================================================
    // �v���p�e�B
    // ==================================================

    /// <summary>
    ///     ����Ώۂ̃J����
    /// </summary>
    [field: SerializeField]
    public BaseCameraModel? ControlCamera { get; set; } = null;

    // ==================================================
    // Public���\�b�h
    // ==================================================

    /// <summary>
    ///     ���̓L�[�ɍ��킹�ăJ�������ړ�����
    /// </summary>
    public void MoveCamera() {

        // ����ΏۃJ������null�Ȃ瑀�삵�Ȃ�
        if (ControlCamera is null) {
            return;
        }


        // W�L�[: ��
        bool isTop = (Input.GetKey(KeyCode.W));
        // A�L�[: ��
        bool isLeft = (Input.GetKey(KeyCode.A));
        // D�L�[: �E
        bool isRight = (Input.GetKey(KeyCode.D));
        // S�L�[: ��
        bool isBottom = (Input.GetKey(KeyCode.S));

        // �g�ݍ��킹�L�[�̏���

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

        // �P��L�[�̏���

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
    // Event�n���h��
    // ==================================================

    /// <summary>
    ///     ����Ăяo�����̏���
    /// </summary>
    public void Start() {
        
    }

    /// <summary>
    ///     ���b�Ăяo����鏈��
    /// </summary>
    public void Update() {

        MoveCamera();
    }
}
