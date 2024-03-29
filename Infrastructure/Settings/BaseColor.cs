﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev69Restaurant.Infrastructure.Settings
{
    public static class BaseColor
    {
        #region Light Theme
        public static readonly Color BACK_COLOR_LIGHT = Color.FromArgb(240, 247, 247);
        public static readonly Color BUTTON_LIGHT = Color.FromArgb(255, 255, 255);
        public static readonly Color PANNEL_LIGHT = Color.FromArgb(255, 255, 255);
        public static readonly Color FORE_COLOR_LIGHT = Color.FromArgb(64, 64, 64);
        public static readonly Color FORE_COLOR_LIGHT_HOVER = Color.FromArgb(255, 77, 165);
        public static readonly Color FORE_COLOR_LIGHT_ACTIVE = Color.FromArgb(255, 77, 165);
        public static readonly Color PRESS_COLOR_PRIMARY = Color.FromArgb(216, 217, 220);
        public static readonly Color PRESS_COLOR_PRIMARY_ACTIVE = Color.FromArgb(216, 217, 220);
        #endregion
        #region Dark Theme
        public static readonly Color BACK_COLOR_DARK = Color.FromArgb(24, 26, 32);
        public static readonly Color BUTTON_DARK = Color.FromArgb(38, 42, 52);
        public static readonly Color PANNEL_DARK = Color.FromArgb(38, 42, 52);
        public static readonly Color FORE_COLOR_DARK = Color.FromArgb(255, 255, 255);
        public static readonly Color FORE_COLOR_DARK_HOVER = Color.FromArgb(255, 77, 165);
        public static readonly Color FORE_COLOR_DARK_ACTIVE = Color.FromArgb(255, 77, 165);
        #endregion
    }
}
