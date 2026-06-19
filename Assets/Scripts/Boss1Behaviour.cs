using UnityEngine;

public class Boss1Behaviour : MonoBehaviour {
    private void Attack() {
        AttackType attackType = AttackType.CHARGE;

        attackType = (AttackType)Random.Range(0, 2);

        if (attackType == AttackType.CHARGE)
        {
            // fait une charge
        }

        else
        {
            // fait un jump
        } 
    }
}