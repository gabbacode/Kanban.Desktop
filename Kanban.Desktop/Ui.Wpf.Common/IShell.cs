﻿using Autofac;
using Xceed.Wpf.AvalonDock;

namespace Ui.Wpf.Common
{
    public interface IShell 
    {
        string Title { get; set; }

        IContainer Container { get; set; }

        void ShowView<TView>(
            ViewRequest viewRequest = null, 
            UiShowOptions options = null)
            where TView : class, IView;

        void ShowTool<TToolView>(
            ViewRequest viewRequest = null,
            UiShowOptions options = null)
            where TToolView : class, IToolView;

        void ShowStartView<TStartWindow>()
            where TStartWindow : class;

        void ShowStartView<TStartWindow, TStartView>()
            where TStartWindow : class
            where TStartView : class, IView;

        void AttachDockingManager(DockingManager dockingManager);

    }
}