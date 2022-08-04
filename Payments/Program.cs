using System;
using System.Runtime.InteropServices;

namespace Payments
{
    class Program
    {
        static void Main(string[] args){   
            Console.WriteLine("Hello");
            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }

        static void OnRoomSoldOut(object sender, EventArgs e){
            Console.WriteLine("Sala Lotada!");
        }
    }

    public class Room{

        public Room(int seats){
            Seats = seats;
            seatsInUse = 0;
        }
        private int seatsInUse = 0;
        public int Seats { get; set; }

        public void ReserveSeat(){
            seatsInUse++;
            if (seatsInUse >= Seats){
                OnRoomSoldOut(EventArgs.Empty);
            } else {
                Console.WriteLine("Assento reservado");
            }
        }

        public event EventHandler RoomSoldOutEvent;

        protected virtual void OnRoomSoldOut(EventArgs e) {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);
        }
    }
}
