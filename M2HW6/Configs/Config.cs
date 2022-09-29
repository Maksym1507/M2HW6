﻿using Autofac;
using M2HW6.Interfaces;
using M2HW6.Services;

namespace M2HW6.Configs
{
    public class Config
    {
        public Config()
        {
            Builder = new ContainerBuilder();
        }

        private ContainerBuilder Builder { get; set; }

        public IContainer RegisterTypes()
        {
            Builder.RegisterType<NotificationService>().As<INotificationService>();
            Builder.RegisterType<MaintenanceStationService>().As<IMaintenanceStationService>();
            Builder.RegisterType<Starter>();
            return Builder.Build();
        }
    }
}
