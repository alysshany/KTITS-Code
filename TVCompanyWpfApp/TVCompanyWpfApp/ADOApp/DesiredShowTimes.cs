//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TVCompanyWpfApp.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class DesiredShowTimes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DesiredShowTimes()
        {
            this.Advertisements = new HashSet<Advertisements>();
        }
    
        public int DesiredShowTime_Id { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advertisements> Advertisements { get; set; }
    }
}
