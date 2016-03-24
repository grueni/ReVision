﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    public class StatusStrip : ToolStrip
    {
        public StatusStrip()
        {
            this.Dock = DockStyle.Bottom;
            this.Height = 24;
        }

        public override string ControlName
        {
            get
            {
                return "StatusStrip";
            }
        }
    }
}
