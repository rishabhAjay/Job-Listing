namespace JobListing.Data.Entities;
public enum JobTypesEnums
{
    FullTime, PartTime, Contract
}

public class JobTypes
{
    public static string? ToFriendlyString(JobTypesEnums jobTypes)
    {
        return jobTypes switch
        {
            JobTypesEnums.FullTime => "Full-Time",
            JobTypesEnums.PartTime => "Part-Time",
            JobTypesEnums.Contract => "Contract",
            _ => null,
        };
    }
}