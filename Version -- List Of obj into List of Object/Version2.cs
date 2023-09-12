using Algorithms.Data;

namespace ConsoleApp1.Version____List_Of_obj_into_List_of_Object;

public class Version2
{
    public void Version_02(List<NewCarService> carServiceDataList)  /// the more optimized version 
    {
        //List<NewCarService> carServiceDataList = new();
        Dictionary<(int, int, string), CarServices> carServicesDictionary = new();

        foreach (var carServiceData in carServiceDataList)
        {
            var key = (carServiceData.ServiceId, carServiceData.ServiceTypeId, carServiceData.ServiceName);

            if (!carServicesDictionary.TryGetValue(key, out var existingCarService))
            {
                existingCarService = new CarServices
                {
                    ServiceId = carServiceData.ServiceId,
                    ServiceTypeId = carServiceData.ServiceTypeId,
                    ServiceName = carServiceData.ServiceName,
                    listSubServiceName = new List<SubServices?>()
                };
                carServicesDictionary[key] = existingCarService;
            }
        }

        foreach (var item in carServiceDataList)
        {
            var key = (item.ServiceId, item.ServiceTypeId, item.ServiceName);
            if (carServicesDictionary.TryGetValue(key, out var carService))
            {
                carService.listSubServiceName?.Add(new SubServices
                {
                    SubServiceId = item.SubServiceId,
                    SubServiceName = item.SubServiceName
                });
            }
        }

        List<CarServices> carServicesList = carServicesDictionary.Values.ToList();

        /// This optimization reduces the time complexity of 
        /// your operations from O(N^2) to O(N), where N is the 
        /// size of the carServiceDataList. 
        /// Verion 01 to version 02 difference
        /// 

        #region Check Purpose

        //List<NewCarService> carServiceDataList = new();
        //Dictionary<(int, int, string), CarServices> carServicesDictionary = new();

        //foreach (var carServiceData in carServiceDataList)
        //{
        //    var key = (carServiceData.ServiceId, carServiceData.ServiceTypeId, carServiceData.ServiceName);

        //    if (!carServicesDictionary.TryGetValue(key, out var existingCarService))
        //    {
        //        existingCarService = new CarServices
        //        {
        //            ServiceId = carServiceData.ServiceId,
        //            ServiceTypeId = carServiceData.ServiceTypeId,
        //            ServiceName = carServiceData.ServiceName,
        //            listSubServiceName = new List<SubServices?>()
        //        };
        //        carServicesDictionary[key] = existingCarService;
        //    }

        //    if (carServiceData.SubServiceId.HasValue)
        //    {
        //        existingCarService.listSubServiceName?.Add(new SubServices
        //        {
        //            SubServiceId = carServiceData.SubServiceId,
        //            SubServiceName = carServiceData.SubServiceName
        //        });
        //    }
        //}

        //List<CarServices> carServicesList = carServicesDictionary.Values.ToList();
        #endregion
    }
}

