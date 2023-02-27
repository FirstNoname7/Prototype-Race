using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //���� ������ ����� ��� ����, ���� ������ ��������� �� ������� (�� �������), ����� ��� ����� ���������. ����� ����� ����� ��, ��� ����� ������ (������ ������)
    public GameObject player; //�����, ����� ���� � ���������� ��������� ������, �� ������� ����� ������ �����
    private Vector3 offset; //��������� ������ ������������ ���������� � ������ offset. ��� �������� � ����� ����� ����� ����������� (�������).
    //� � ������� ���� ���� �������, ��� ��������� ������ ���������� �� ��������� (�� ��� Y) ������ (�� 5) � ����� (�� ��� Z) (�� -15).
    private Vector3 offsetBack = new Vector3(0,5,-15); //������ ��������� ������ (����� �� ������) 
    public Vector3 offsetOn = new Vector3(0, 2, 1); //������ ��������� ������ (����� �� �� ����� ��������)
    bool conditions = false; //������� ��� ������������ ������ (��� - �� �� ����� ��������, ���� - �� ������)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //������ Update ������ LateUpdate, ����� ������ �� �������, ��� �� ������ (���� 2 ������ ���� rigidbody �� ������ ���� � ����� � �� ��������� ��� ����� �����, �������� ���� ������)
    {
        if(Input.GetKeyDown(KeyCode.Q)) //���� ������ �� ������ Q, �����:
        {
            conditions =!conditions; //���������� ������� ��� �������� � true �� false, � false �� true
        }
        offset = conditions ? offsetOn : offsetBack; //������������ ������ (������� ���� ��� ��������, ���� ������ �� ����������)
        transform.position = player.transform.position + offset; //������� �������, � �������� ��������� ���� ������ = ������� ������ + ������� ������ 
                                                                 //���� ������������ offsetBack, �� ������ (��� ����������, ������� ����� �������) (�� ��������� (�� ��� Y) �� 5 ������) � ����� (�� ��� Z �� 17 ������ �����)
    }
}
