﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squiggle.UI.Windows;
using Squiggle.Chat;
using Squiggle.Activities;

namespace Squiggle.UI.Components
{
    class SquiggleContext
    {
        public MainWindow MainWindow { get; set; }
        public PluginLoader PluginLoader { get; set; }
        public IChatClient ChatClient { get; set; }
        public IVoiceChat ActiveVoiceChat { get; set; }
        public bool IsVoiceChatActive
        {
            get { return ActiveVoiceChat != null; }
        }

        public static SquiggleContext Current = new SquiggleContext();
    }
}