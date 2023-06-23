using UniRx;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private ReactiveProperty<int> hp;
    public ReactiveProperty<int> Hp => hp;

    public void IncreaseHp(int amount)
    {
        if (amount == 0)
        {
            Debug.LogError("Trying to add 0", this);
            return;
        }

        if (amount < 0)
        {
            Debug.LogError("Trying to add a negative value", this);
            return;
        }

        hp.Value += amount;
    }

    public void DecreaseHp(int amount)
    {
        if (amount == 0)
        {
            Debug.LogError("Trying to subtract 0", this);
            return;
        }

        if (amount < 0)
        {
            Debug.LogError("Trying to subtract a negative value", this);
            return;
        }

        hp.Value -= amount;
    }
}