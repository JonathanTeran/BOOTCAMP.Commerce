﻿using System;
using MediatR;

namespace Catalog.Service.EventHandlers.Commands
{
    public class ProductCreateCommand : INotification
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

    }
}

