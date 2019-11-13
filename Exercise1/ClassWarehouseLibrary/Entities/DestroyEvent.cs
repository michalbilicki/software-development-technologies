﻿using System;

namespace ClassWarehouseLibrary.Entities
{
    public class DestroyEvent : Event
    {
        public DestroyEvent(Guid id, Client warehouseClient, Status status, string description) : base(id, warehouseClient, status, description)
        {
            
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
