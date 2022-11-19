using Core.Dto;

namespace Business.Journey.Dto.Result;

public class PolicyForDetail : IDto
{
    public int MaxSeats { get; set; }
    public int MaxSingle { get; set; }
    public int MaxSingleMales { get; set; }
    public int MaxSingleFemales { get; set; }
    public bool MixedGenders { get; set; }
    public bool GovId { get; set; }
    public bool Lht { get; set; }
}
