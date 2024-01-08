namespace FormulaOne.Domain;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime AddedDate { get; set; } = DateTime.Now;
    public DateTime UpdateDate { get; set; } = DateTime.Now;
    public int Status { get; set; }
}
