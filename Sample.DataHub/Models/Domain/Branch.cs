namespace Sample.DataHub.Models.Domain
{
    public class Branch
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? BranchImageURL { get; set; }
    }
}
