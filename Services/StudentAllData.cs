using UserManagementSystem.Models;
namespace UserManagementSystem.Services
{
    static class StudentAllData
    {
       private static List<StdModel> _allData = new List<StdModel>();

        public static List<StdModel> ShowAll()
        {

            return _allData;
        }

        public static void Add(StdModel model)
        {
            //_allData.Add(new StdModel());
            _allData.Add(model);
        }
    }
}
