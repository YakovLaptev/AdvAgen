//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvAgen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class order
    {
        [Display(Name = "Номер заказа")]
        public int number { get; set; }
        public Nullable<int> customerId { get; set; }
        [Display(Name = "Название рекламы")]
        public string advertisingName { get; set; }
        [Display(Name = "Дата создания")]
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<int> statusId { get; set; }
        [Display(Name = "Реклама")]
        public virtual advertising advertising { get; set; }
        [Display(Name = "Заказчик")]
        public virtual customer customer { get; set; }
        [Display(Name = "Статус")]
        public virtual status status { get; set; }
    }
}
