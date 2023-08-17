
public class CarServices
{
    public int ServiceId { get; set; }
    public int ServiceTypeId { get; set; }
    public string? ServiceName { get; set; }
    public List<SubServices?>? listSubServiceName { get; set; }
}

public class SubServices
{
    public int SubServiceId { get; set; }
    public string? SubServiceName { get; set; }
}

public class NewCarService
{
    public int ServiceId { get; set; }
    public int ServiceTypeId { get; set; }
    public string? ServiceName { get; set; }
    public int SubServiceId { get; set; }
    public string? SubServiceName { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {

        List<NewCarService> carServiceDataList = new();
        List<CarServices> carServicesList = new();

        foreach (var carServiceData in carServiceDataList)
        {
            var existingCarService = carServicesList
                .FirstOrDefault(x =>
                    x.ServiceId == carServiceData.ServiceId &&
                    x.ServiceTypeId == carServiceData.ServiceTypeId &&
                    x.ServiceName == carServiceData.ServiceName
                    );

            if (existingCarService == null)
            {
                carServicesList.Add(new CarServices
                {
                    ServiceId = carServiceData.ServiceId,
                    ServiceTypeId = carServiceData.ServiceTypeId,
                    ServiceName = carServiceData.ServiceName,
                    listSubServiceName = new List<SubServices?>()
                });
            }
        }

        foreach (var carServiceData in carServiceDataList)
        {
            var carService = carServicesList
                .FirstOrDefault(x =>
                    x.ServiceId == carServiceData.SubServiceId);

            if (carService != null)
            {
                foreach (var subServiceName in carServiceDataList)
                {
                    carService.listSubServiceName?.Add(new SubServices
                    {
                        SubServiceId = subServiceName.SubServiceId,
                        SubServiceName = subServiceName.SubServiceName
                    });
                }
            }
        }
    }



}
