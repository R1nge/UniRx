using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI healthText;
    [SerializeField] private Button damageButton, healButton;
    [SerializeField] private Health player;
    private HealthView _healthView;

    private void Awake()
    {
        _healthView = new HealthView(healthText);
        player.Hp.Subscribe(UpdateView);
        damageButton.OnClickAsObservable().Subscribe(_ => player.DecreaseHp(1));
        healButton.OnClickAsObservable().Subscribe(_ => player.IncreaseHp(1));
    }

    private void UpdateView(int value) => _healthView.UpdateHealthText(value);
}