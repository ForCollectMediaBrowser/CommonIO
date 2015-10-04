﻿using Patterns.Logging;

namespace CommonIO.Windows
{
    public class WindowsFileSystem : ManagedFileSystem
    {
        public WindowsFileSystem(ILogger logger)
            : base(logger, true, true)
        {
            AddShortcutHandler(new LnkShortcutHandler());
            EnableFileSystemRequestConcat = false;
        }
    }
}
