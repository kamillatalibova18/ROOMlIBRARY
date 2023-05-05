using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLength;
        double roomWidth;

        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="np"></param>
        /// <returns></returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
        public string Info()
        {
            return "Жилая комната площадью " + RoomArea() + " кв.м";
        }
    }
    /// <summary>
    /// Класс "Жилая комната"
    /// </summary>
    public class LivingRoom : Room
    {
        int numWin; // число окон
        public int NumWin
        { get { return numWin; } set { numWin = value; } }
        /// <summary>
        /// Метод возвращает информацию о комнате
        /// </summary>
        /// <returns>Возвращается строка с информацией</returns>
        public string Info()
        {
            return "Жилая комната площадью " + RoomArea() + " кв.м, с " + numWin + " окнами";
        }
    }
    public class Office : Room
    {
        int numSockets; // число розеток
        public int NumSockets
    { get { return numSockets; } set { numSockets = value; } }
    /// <summary>
    /// Возвращает максимально возможное число рабочих мест
    /// </summary>
    /// <returns>Возвращается число мест</returns>
    public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, num);
        }
    /// <summary>
    /// Метод возвращает информацию об офисе
    /// </summary>
    /// <returns>Возвращается строка с информацией</returns>
    public string Info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест"; 
        }
    }
}

