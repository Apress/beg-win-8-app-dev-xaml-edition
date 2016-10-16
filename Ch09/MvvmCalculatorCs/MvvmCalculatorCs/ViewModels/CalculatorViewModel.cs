using System.Windows.Input;
using MvvmCalculatorCs.Common;

namespace MvvmCalculatorCs.ViewModels
{
    public class CalculatorViewModel : BindableBase
    {
        public CalculatorViewModel()
        {
            AddCommand = new DelegateCommand(
                o =>
                {
                    Result = Operand1.Value + Operand2.Value;
                }
                , o =>
                {
                    return Operand1.HasValue && Operand2.HasValue;
                });

            ClearCommand = new DelegateCommand(
                o =>
                {
                    Operand1 = null;
                    Operand2 = null;
                    Result = null;
                }
                , o =>
                {
                    return true;
                });

            PropertyChanged += (sender, args) =>
                ((DelegateCommand)AddCommand).RaiseCanExecuteChanged();
        }

        private int? _operand1;
        public int? Operand1
        {
            get { return _operand1; }
            set { SetProperty(ref _operand1, value); }
        }

        private int? _operand2;
        public int? Operand2
        {
            get { return _operand2; }
            set { SetProperty(ref _operand2, value); }
        }

        private int? _result;
        public int? Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }

        public ICommand AddCommand
        {
            get;
            private set;
        }

        public ICommand ClearCommand
        {
            get;
            private set;
        }
    }

}
