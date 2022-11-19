using Core.Dto;

namespace Business.Journey.Dto.Result;

public class FeatureForJourney : IDto
{
    public int Id { get; set; }
    public int Priority { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public bool IsPromoted { get; set; }
    public string BackColor { get; set; } = default!;
    public string ForeColor { get; set; } = default!;
}