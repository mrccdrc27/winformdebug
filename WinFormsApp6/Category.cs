using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class Category
    {
        public int CategoryId { get; set; } // =1
        public string? Name { get; set; }
        public virtual ObservableCollectionListSource<Product> Products { get; } = new();
    }
}
