using UnityEngine;

/// <summary> NPC �w�q NPC ��k
public class NPC : MonoBehaviour
{
    /// <summary>
    /// ��ܥ\��
    /// </summary>
    /// <param name="dialogue">NPC �n������ܤ��e </param>
    private void Dialogue(string dialogue)
    {

    }
    /// <summary>
    /// �}�Ұө� 
    /// </summary>
    public bool Openshop()
    {
        return true;
    }

    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="price">�D�����</param>
    public int Shopping(int price = 100)
    {
        return 0;
    }

    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="indexMission">���Ƚs��</param>
    public void Getmission(int indexMission)
    {

    }

    /// <summary>
    /// ��s����
    /// /// </summary>
    /// <param name="propMission">���ȹD��ƶq</param>
    private int UpdateMission(int propMission = 1)
    {
        return 0;
    }

    /// <summary>
    /// ��������
    /// </summary>
    ///<param name="indexMission">���Ƚs��</param>
    private bool MissionUpdate(int indexMission)
    {
        return false;
    }
}