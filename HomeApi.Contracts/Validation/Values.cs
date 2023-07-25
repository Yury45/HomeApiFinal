using System.Linq;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-хранилище допустымых значений для валидаторов
    /// </summary>
    public static class Values
    {
        public static string [] ValidRooms = new  []
        {
            "Кухня",
            "Ванная",
            "Гостиная",
            "Туалет"
        };

        public static bool BeSupported(string location)
        {
            // Проверим, содержится ли значение в списке допустимых
            return Values.ValidRooms.Any(e => e == location);
        }
    }
}