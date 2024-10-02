using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class WeightPage : ContentPage
{
    private double KeyValue = 0;
    
    private double dbl_p2k  = 0.453592;
    private double dbl_p2p  = 1;
    private double dbl_p2mg = 453592;
    private double dbl_p2t   = 0.0005;

    
    public WeightPage()
    {
        InitializeComponent();
        
        Title = "Weight Converter";

        ToolbarItem tbi = new ToolbarItem();
        tbi.Text = "About";
        this.ToolbarItems.Add(tbi);

        tbi.Clicked += delegate
        {
            Navigation.PushAsync(new AboutPage());
        };
    }

    private void TxtPounds_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2p
        double dblNumber;
        var isValid = Double.TryParse(txtPounds.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2p;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtKilograms_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2k
        double dblNumber;
        var isValid = Double.TryParse(txtKilograms.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2k;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtTons_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2t
        double dblNumber;
        var isValid = Double.TryParse(txtTons.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2t;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtMilligrams_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2mg
        double dblNumber;
        var isValid = Double.TryParse(txtMilligrams.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2mg;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtPounds.Text = "";
        txtKilograms.Text = "";
        txtMilligrams.Text = "";
        txtTons.Text = "";
    }

    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtPounds.Text = (KeyValue * dbl_p2p).ToString("g9");
        txtKilograms.Text = (KeyValue * dbl_p2k).ToString("g9");
        txtMilligrams.Text = (KeyValue * dbl_p2mg).ToString("g9");
        txtTons.Text = (KeyValue * dbl_p2t).ToString("g9");
    }
}