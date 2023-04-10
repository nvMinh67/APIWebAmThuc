﻿using System.ComponentModel.DataAnnotations.Schema;

namespace webanthuc.Entity
{
    public class RoomDetail
    {
        public int Id { get; set; }
        public int Id_Hotels { get; set; }
        [ForeignKey("Id_Hotels")]
        public Hotel Hotel { get; set;}
        public int Id_Room1s { get; set; }
        [ForeignKey("Id_Rooms1")]
        public Room1 Room1 { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public string View { get; set; }
        public bool IsActived { get; set; }
        public int Capacity { get; set; }
    }
}
