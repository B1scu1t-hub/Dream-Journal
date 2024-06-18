namespace C_WebAPI_1.Services
{
    public class BiscuitService
    {
        public string GetBiscuitDetails(int id)
        {
            return $"Details of Biscuit {id}";
        }

        public IEnumerable<string> GetBiscuitTypes()
        {
            return new List<string> { "Chocolate", "Oatmeal", "Digestive" };
        }
    }
}
