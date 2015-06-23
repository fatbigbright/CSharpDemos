using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVMDemo.Model;

namespace MVVMDemo.ViewModel
{
   public class DelegateCommand : ICommand
   {
      public Action<object> ExecuteCommand = null;
      public Func<object, bool> CanExecuteCommand = null;

      public bool CanExecute(object parameter)
      {
         if (CanExecuteCommand != null)
         {
            return this.CanExecuteCommand(parameter);
         }
         else
         {
            return true;
         }
      }

      public void Execute(object parameter)
      {
         if (ExecuteCommand != null)
         {
            ExecuteCommand(parameter);
         }
      }

      public event EventHandler CanExecuteChanged;

      public void RaiseCanExecuteChanged()
      {
         if (CanExecuteChanged != null) CanExecuteChanged(this, EventArgs.Empty);
      }
   }
   public class ContentViewModel
   {
      public DelegateCommand ShowCommand { get; set; }
      public DelegateCommand ClearCommand { get; set; }
      public ContentModel Content { get; set; }
      public ContentViewModel()
      {
         Content = new ContentModel();
         ShowCommand = new DelegateCommand();
         ShowCommand.ExecuteCommand = new Action<object>(obj => { 
            Content.Text = "This is all what can be show to you!"; 
         });

         ClearCommand = new DelegateCommand();
         ClearCommand.ExecuteCommand = new Action<object>(obj => { 
            Content.Text = string.Empty; 
         });
      }
   }
}
