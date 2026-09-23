namespace bmi2026labtest;

using BMICalculator;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    [DataRow(9, 0, 6, 0, BMICategory.Underweight)]
    [DataRow(11, 0, 6, 0, BMICategory.Normal)]
    [DataRow(14, 0, 6, 0, BMICategory.Overweight)]
    [DataRow(20, 0, 6, 0, BMICategory.Obese)]
    public void BMICategory_ReturnsExpectedCategory(
        int weightStones,
        int weightPounds,
        int heightFeet,
        int heightInches,
        BMICategory expectedCategory)
    {
        var bmi = new BMI
        {
            WeightStones = weightStones,
            WeightPounds = weightPounds,
            HeightFeet = heightFeet,
            HeightInches = heightInches
        };

        Assert.AreEqual(expectedCategory, bmi.BMICategory);
    }
}
