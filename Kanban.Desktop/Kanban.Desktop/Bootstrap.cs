﻿using System;
using Autofac;
using Data.Sources.Common.Redmine;
using Data.Sources.Redmine;
using Kanban.Desktop.KanbanBoard;
using Ui.Wpf.Common;

namespace Kanban.Desktop
{
    public class Bootstrap : IBootstraper
    {
        public Shell Init()
        {
            var container = ConfigureContainer();
            var shell = container.Resolve<Shell>();

            shell.Container = container;

            return shell;            
        }

        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Shell>().SingleInstance();

            builder.RegisterType<MainWindow>().As<IDockWindow>();

            ConfigureKanbanBoard(builder);

            ConfigureRemine(builder);

            return builder.Build();
        }

        private static void ConfigureKanbanBoard(ContainerBuilder builder)
        {
            builder
                .RegisterType<KanbanBoardViewModel>()
                .As<IKanbanBoardViewModel>();

            builder
                .RegisterType<KanbanBoardView>()
                .As<IKanbanBoardView>();


            builder
                .RegisterType<KanbanConfigurationRepository>()
                .As<IKanbanConfigurationRepository>();
        }

        private static void ConfigureRemine(ContainerBuilder builder)
        {
            builder
                .RegisterType<RedmineRepository>()
                .As<IRedmineRepository>();
        }
    }
}
