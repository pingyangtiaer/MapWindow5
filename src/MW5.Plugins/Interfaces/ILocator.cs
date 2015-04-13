﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Interfaces;
using MW5.Plugins.Enums;

namespace MW5.Plugins.Interfaces
{
    public interface ILocator: IDockPanelPresenter
    {
        void RestorePicture(Image image, double dx, double dy, double xllCenter, double yllCenter);
        IImageSource Picture { get; }
        void Clear();
        void Update(PreviewExtents updateExtents);
        bool Empty { get; }
    }
}
