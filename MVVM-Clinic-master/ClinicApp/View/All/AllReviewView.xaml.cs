﻿using ClinicApp.ViewModel;
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

namespace ClinicApp.View.All
{
    /// <summary>
    /// Interaction logic for AllReviewView.xaml
    /// </summary>
    public partial class AllReviewView : UserControl
    {
        public AllReviewView()
        {
            InitializeComponent();
            this.DataContext = new ReviewViewModel();
        }
    }
}
