using System.Text.Json.Serialization;

public class CalculationRequest
{
    [JsonPropertyName("number1")]
    [JsonRequired]
    public double Number1 { get; set; }

    [JsonPropertyName("number2")]
    [JsonRequired]
    public double Number2 { get; set; }
}