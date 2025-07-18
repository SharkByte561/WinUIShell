﻿using WinUIShell.Common;

namespace WinUIShell;

public class NavigationViewItemSeparator : NavigationViewItemBase
{
    public NavigationViewItemSeparator()
    {
        Id = CommandClient.Get().CreateObject(
            "Microsoft.UI.Xaml.Controls.NavigationViewItemSeparator, Microsoft.WinUI",
            this);
    }
}
