#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace SampleBrowser.SfTreeMap
{
    [Preserve(AllMembers = true)]
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hierarchical : SampleView
    {
        public Hierarchical()
        {
            InitializeComponent();
            this.BindingContext = this;
            //Title = "Hierarchical";


            this.TreeMap.DataSource = new CountrySalesCollection();
        }
    }
}