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

        public static void Delete(StdModel model)
        {
            var id = _allData.Where(x => x.Id == model.Id).FirstOrDefault();
            _allData.Remove(id);
        }

        public static void Update(StdModel stdUpdate)
        {
            var id = _allData.Where(x => x.Id == stdUpdate.Id).FirstOrDefault();
            //var name = _allData.Where(x => x.Name == stdUpdate.Name).FirstOrDefault();
            //string name = id.Name;
            //stdUpdate.Name = name;

            id.Name = stdUpdate.Name;

            

            //_allData.Add();
        }

    }
}
