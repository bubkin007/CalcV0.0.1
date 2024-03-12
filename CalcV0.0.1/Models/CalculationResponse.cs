using System.Text.Json.Serialization;

public class CalculationResponse
{
    [JsonPropertyName("result")]
    public double Result { get; set; }
}