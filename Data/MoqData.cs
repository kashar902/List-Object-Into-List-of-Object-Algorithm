namespace Algorithms.Data;

public class CarServices
{
    public int ServiceId { get; set; }
    public int ServiceTypeId { get; set; }
    public string? ServiceName { get; set; }
    public List<SubServices?>? listSubServiceName { get; set; }
}

public class SubServices
{
    public int? SubServiceId { get; set; }
    public string? SubServiceName { get; set; }
}

public class NewCarService
{
    public int ServiceId { get; set; }
    public int ServiceTypeId { get; set; }
    public string? ServiceName { get; set; }
    public int? SubServiceId { get; set; }
    public string? SubServiceName { get; set; }
}

