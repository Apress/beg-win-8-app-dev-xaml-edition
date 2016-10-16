using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace DependencyObjectSampleCs.Entities
{
    class Person : DependencyObject
    {
        public static readonly DependencyProperty LastNameProperty
            = DependencyProperty.Register("LastName", typeof(string)
                , typeof(Person), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty FirstNameProperty
            = DependencyProperty.Register("FirstName", typeof(string)
                , typeof(Person), new PropertyMetadata(string.Empty));

        public string LastName
        {
            get 
            {
                return (string)GetValue(LastNameProperty);
            }
            set 
            {
                SetValue(LastNameProperty, value);
            }
        }

        public string FirstName
        {
            get
            {
                return (string)GetValue(FirstNameProperty);
            }
            set
            {
                SetValue(FirstNameProperty, value);
            }
        }
    }
}
