﻿namespace HomeApi.Data.Queries
{
    /// <summary>
    /// Класс для передачи дополнительных параметров при обновлении устройства
    /// </summary>
    public class UpdateDeviceQuery
    {
        public string NewName { get; }
        public string NewSerial{ get; }
        public string NewRoom { get; }

        public UpdateDeviceQuery(string newName = null, string newSerial = null, string newRoom = null)
        {
            NewName = newName;
            NewSerial = newSerial;
            NewRoom = newRoom;

        }
    }
}