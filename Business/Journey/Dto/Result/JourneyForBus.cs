using Core.Dto;

namespace Business.Journey.Dto.Result;

public class JourneyForBus : IDto
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public string PartnerName { get; set; } = default!;
    public int RouteId { get; set; }
    public string BusType { get; set; } = default!;
    public string BusTypeName { get; set; } = default!;
    public int TotalSeats { get; set; }
    public int AvailableSeats { get; set; }
    public string OriginLocation { get; set; } = default!;
    public string DestinationLocation { get; set; } = default!;
    public bool IsActive { get; set; }
    public int OriginLocationId { get; set; }
    public int DestinationLocationId { get; set; }
    public bool IsPromoted { get; set; }
    public int CancellationOffset { get; set; }
    public bool HasBusShuttle { get; set; }
    public bool DisableSalesWithoutGovId { get; set; }
    public string DisplayOffset { get; set; } = default!;
    public double PartnerRating { get; set; }
    public bool HasDynamicPricing { get; set; }
    public bool DisableSalesWithoutHesCode { get; set; }
    public bool DisableSingleSeatSelection { get; set; }
    public int ChangeOffset { get; set; }
    public int Rank { get; set; }
    public bool DisplayCouponCodeInput { get; set; }
    public bool DisableSalesWithoutDateOfBirth { get; set; }
    public int OpenOffset { get; set; }
    public bool AllowSalesForeignPassenger { get; set; }
    public bool HasSeatSelection { get; set; }
    public bool HasGenderSelection { get; set; }
    public bool HasDynamicCancellation { get; set; }
    public IList<FeatureForJourney> Features { get; set; } = new List<FeatureForJourney>();
    public IList<DetailForJourney> Journey { get; set; } = new List<DetailForJourney>();
}
