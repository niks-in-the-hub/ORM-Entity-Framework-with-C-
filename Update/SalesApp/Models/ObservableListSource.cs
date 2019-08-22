﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SalesApp
{
    class ObservableListSource<T> : ObservableCollection<T>, IListSource where T : BaseModel
    {
        private IBindingList _bindingList;
        bool IListSource.ContainsListCollection { get { return false; } }
        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }
}
