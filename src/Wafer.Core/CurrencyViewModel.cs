using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Wafer.Entity;
namespace Wafer.Core;
public class CurrencyViewModel : ObservableObject
{
    public CurrencyViewModel()
    {
        title = "币别设置";
        currencies = new ObservableCollection<Currency>() {
            new Currency(){CurrencyCode="RMB",CurrencyName="人民币",Rate=1.0000,Basecurrency=true,CurrencyDescription="财务核算基本货币,默认"},
            new Currency(){CurrencyCode="USD",CurrencyName="美元",Rate=6.62,Basecurrency=false,CurrencyDescription="美元,对外使用"},
            new Currency(){ CurrencyCode="RUB",CurrencyName="俄罗斯卢布",Rate=0.091,Basecurrency=false,CurrencyDescription="俄罗斯卢布"}
        };
    }
    private string? title;
    private ICollection<Currency>? currencies;
    public string? Title { get => title; set => SetProperty(ref title, value); }
    public ICollection<Currency> Currencies { get => currencies ?? (currencies = new ObservableCollection<Currency>()); set => SetProperty(ref currencies, value); }
}
