using TMPro;

public class HealthView
{
    private readonly TextMeshProUGUI _healthText;

    public HealthView(TextMeshProUGUI healthText) => _healthText = healthText;

    public void UpdateHealthText(int value) => _healthText.text = value.ToString();
}