//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drying
    {
        public int Number_of_district_drying { get; set; }
        public Nullable<int> Name_of_goods_drying { get; set; }
        public Nullable<int> Quantity_of_drying { get; set; }
    
        public virtual Goods Goods { get; set; }
    }
}