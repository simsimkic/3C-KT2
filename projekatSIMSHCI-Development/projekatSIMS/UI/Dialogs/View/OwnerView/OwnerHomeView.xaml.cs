﻿using projekatSIMS.UI.Dialogs.ViewModel.OwnerHomeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projekatSIMS.UI.Dialogs.View.OwnerView
{
    /// <summary>
    /// Interaction logic for TouristHomeView.xaml
    /// </summary>
    public partial class OwnerHomeView : Page
    {
        public OwnerHomeView()
        {
            InitializeComponent();
            DataContext = new OwnerHomeModel();
        }


    }
}
