namespace ProjectCondensed.Interfaces
{
    public interface ISingleDataUsage<UsageType>
    {
        UsageType UsageField { get; set; }
    }

    public interface I2DataUsages<UsageType1, UsageType2>
    {
        UsageType1 UsageField1 { get; set; }
        UsageType2 UsageField2 { get; set; }
    }
}
