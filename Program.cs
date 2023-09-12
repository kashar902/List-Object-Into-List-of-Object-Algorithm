using Algorithms.YeildReturnConcept;

internal class Program
{
    public static void Main(string[] args)
    {
        YeildReturn yeildReturn = new();
        foreach (int item in yeildReturn.ProduceEvenNumbers(27))
        {
            Console.WriteLine(item);
        }
        #region List Of Object
        //List<NewCarService> dummyData = GenerateDummyData(50);

        //static List<NewCarService> GenerateDummyData(int count)
        //{
        //    List<NewCarService> data = new();

        //    for (int i = 1; i <= count; i++)
        //    {
        //        var serviceId = 1; // Set ServiceId to the same value for all records
        //        var subServiceId = i % 5 == 0 ? null : (int?)i; // Repeat SubServiceId every 5 records

        //        var newCarService = new NewCarService
        //        {
        //            ServiceId = serviceId,
        //            ServiceTypeId = 100 + i, // Just an example value
        //            ServiceName = $"Service {serviceId}",
        //            SubServiceId = subServiceId,
        //            SubServiceName = subServiceId != null ? $"SubService {subServiceId}" : null
        //        };

        //        data.Add(newCarService);
        //    }

        //    return data;
        //}
        //Version2 version2 = new();
        //version2.Version_02(dummyData);
        #endregion

    }



}
