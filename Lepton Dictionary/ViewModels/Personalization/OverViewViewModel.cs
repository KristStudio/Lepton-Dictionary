﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Lepton_Dictionary.ViewModels.Personalization
{
    public class OverViewViewModel : PageViewModelBase
    {
        public OverViewViewModel()
        {
            IsNightMode = Models.Personalization.IsNightMode;
        }
        #region Personalization 个性化
        bool _IsNightMode = false;
        public bool IsNightMode
        {
            get { return _IsNightMode; }
            set
            {
                Set(ref _IsNightMode, value);
                Models.Personalization.IsNightMode = value;
            }
        }
        

        bool _IsFluentDesign = false;
        public bool IsFluentDesign
        {
            get { return _IsFluentDesign; }
            set
            {
                Set(ref _IsFluentDesign, value);

            }
        }

        double _BackgroundAcrylicOpacity = Models.Personalization.AcrylicBrushOpacity;
        public double BackgroundAcrylicOpacity
        {
            get { return _BackgroundAcrylicOpacity; }
            set
            {
                Set(ref _BackgroundAcrylicOpacity, value);
                Models.Personalization.AcrylicBrushOpacity = value;
            }
        }

        string _BackgroundAcrylicOpacityText = "";
        public string BackgroundAcrylicOpacityText
        {
            get { return _BackgroundAcrylicOpacityText; }
            set
            {
                Set(ref _BackgroundAcrylicOpacityText, value);
            }
        }

        Visibility _AcrylicSlideVisibility = 0;
        public Visibility AcrylicSlideVisibility
        {
            get { return _AcrylicSlideVisibility; }
            set
            {
                Set(ref _AcrylicSlideVisibility, value);
            }
        }





        #endregion

    }
}
