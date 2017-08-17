﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CGM.Communication.Data
{
    public class OtherSettings
    {
        public int IntervalSeconds { get; set; } = 300;
        public bool IncludeHistory { get; set; } = true;
        public string TurnOffIfOnThisWifi { get; set; }
    }
}