using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVMDemo.Model
{
   public class ContentModel : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;

      private string _text;
      public string Text 
      {
         get
         {
            return _text;
         }
         set
         {
            _text = value;
            if (PropertyChanged != null)
            {
               PropertyChanged(this, new PropertyChangedEventArgs("Text"));
            }
         }
      }
   }
}
