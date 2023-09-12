using Algorithms.Data;

namespace ConsoleApp1.Version____List_Of_obj_into_List_of_Object;

public class Version1
{
    public void Version_01()
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
        foreach (var item in carServiceDataList)
        {
            foreach (var subServiceName in carServicesList)
            {
                if (subServiceName.ServiceId.Equals(item.ServiceId))
                {
                    subServiceName.listSubServiceName?.Add(new SubServices
                    {
                        SubServiceId = item.SubServiceId,
                        SubServiceName = item.SubServiceName
                    });
                }
            }
        }

        #region Old Version Error In Condition

        //List<NewCarService> carServiceDataList = new();
        //List<CarServices> carServicesList = new();

        //foreach (var carServiceData in carServiceDataList)
        //{
        //    var existingCarService = carServicesList
        //        .FirstOrDefault(x =>
        //            x.ServiceId == carServiceData.ServiceId &&
        //            x.ServiceTypeId == carServiceData.ServiceTypeId &&
        //            x.ServiceName == carServiceData.ServiceName
        //            );

        //    if (existingCarService == null)
        //    {
        //        carServicesList.Add(new CarServices
        //        {
        //            ServiceId = carServiceData.ServiceId,
        //            ServiceTypeId = carServiceData.ServiceTypeId,
        //            ServiceName = carServiceData.ServiceName,
        //            listSubServiceName = new List<SubServices?>()
        //        });
        //    }
        //}

        //foreach (var carServiceData in carServiceDataList)
        //{
        //    var carService = carServicesList
        //        .FirstOrDefault(x =>
        //            x.ServiceId == carServiceData.SubServiceId);

        //    if (carService != null)
        //    {
        //        foreach (var subServiceName in carServiceDataList)
        //        {
        //            carService.listSubServiceName?.Add(new SubServices
        //            {
        //                SubServiceId = subServiceName.SubServiceId,
        //                SubServiceName = subServiceName.SubServiceName
        //            });
        //        }
        //    }
        //}
        #endregion

    }
}
