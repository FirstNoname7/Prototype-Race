using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
    Rigidbody rigidBody; //�������� ��������� ������� ���� ����� ���������� rigidBody
    private float speed = 20.0f; //�������� �������� ���� �����
    public float timer = 10.0f; //������. ����� ��� �������� �����, ������� ������ ��� ���� ������, ���� �� ��������� ������������������ ����

    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>(); //�������, ��� � ���� ������� ����� �������������� ������� ������ � ������ �����, �� ���� � Rigidbody
    }

    // � Update ������ ����� ������������ �����
    void Update()
    {
        timer -= Time.deltaTime; //������ ������������ ���������� ������� �� ������ ����������
        if (timer < 0) //���� ������ ����������, �����:
        {
            Destroy(gameObject); //������� ������ (���) ���������
        }

        rigidBody.velocity = new Vector3(0,0,-1) * speed; //��� ��������������� �������� �����.
                                                      //rigidBody. - ������������� ������� ����. velocity - �������, ��� ������ ������ ���������.
                                                      //Vector3.forward - ��, ��� ����������� ������ �� ��� Z (������ ����������, ��� ����� �������� �������� � �����)
                                                      //speed - ��������. ��� ������ �����, ��� ������ ��������

    }
}
