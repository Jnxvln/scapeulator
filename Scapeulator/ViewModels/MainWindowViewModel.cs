using System.Collections.ObjectModel;
using System.Windows;
using Scapeulator.MVVM;
using Scapeulator.MVVM.Commands;

namespace Scapeulator.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<string> _shapeList;
    
    private string _inputA = string.Empty;
    private string _inputB = string.Empty;
    private string _inputC = string.Empty;
    private string _inputD = string.Empty;
    private string _outputResult = string.Empty;
    private string _shapeSelected;

    public string InputA
    {
        get => _inputA;
        set
        {
            _inputA = value;
            OnPropertyChanged();
        }
    }

    public string InputB
    {
        get => _inputB;
        set
        {
            _inputB = value;
            OnPropertyChanged();
        }
    }

    public string InputC
    {
        get => _inputC;
        set
        {
            _inputC = value;
            OnPropertyChanged();
        }
    }

    public string InputD
    {
        get => _inputD;
        set
        {
            _inputD = value;
            OnPropertyChanged();
        }
    }

    public string Result
    {
        get => _outputResult;
        set
        {
            _outputResult = value;
            OnPropertyChanged();
        }
    }

    public string LabelInputA { get; set; } = string.Empty;
    public string LabelInputB { get; set; } = string.Empty;
    public string LabelInputC { get; set; } = string.Empty;
    public string LabelInputD { get; set; } = string.Empty;
    
    
    public string ShapeTitle { get; set; } = string.Empty;

    public string ShapeSelected
    {
        get => _shapeSelected;
        set
        {
            _shapeSelected = value;
            OnPropertyChanged();
        }
    }


    public ObservableCollection<string> ShapeList
    {
        get => _shapeList;
        set
        {
            _shapeList = value;
            OnPropertyChanged();
        }
    }
    
    public RelayCommand CalculateCommand { get; set; }
    public RelayCommand ClearCommand { get; set; }
    public RelayCommand ChangeShapeCommand { get; set; }

    public MainWindowViewModel()
    {
        CalculateCommand = new RelayCommand(Calculate, CanCalculate);
        ClearCommand = new RelayCommand(Clear, CanClear);
        ChangeShapeCommand = new RelayCommand(ChangeShape, CanChangeShape);
        ShapeList = new ObservableCollection<string>
        {
            "Rectangle",
            "Rectangle Border",
            "Circle",
            "Circle Border",
            "Circle Annulus",
            "Triangle",
            "Trapezoid"
        };
    }

    private bool CanChangeShape(object obj)
    {
        return true;
    }

    private void ChangeShape(object obj)
    {
        MessageBox.Show("Shape changed!");
    }

    private bool CanClear(object obj)
    {
        return true;
    }

    private void Clear(object obj)
    {
        InputA = string.Empty;
        InputB = string.Empty;
        InputC = string.Empty;
        InputD = string.Empty;
        Result = string.Empty;
        MessageBox.Show("Cleared (TODO Focus InputA)");
    }

    private bool CanCalculate(object obj)
    {
        return true;
    }

    private void Calculate(object obj)
    {
        MessageBox.Show("TODO Calculate");
    }
}