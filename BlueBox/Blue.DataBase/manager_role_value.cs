//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blue.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class manager_role_value
    {
        public int id { get; set; }
        public Nullable<int> role_id { get; set; }
        public string nav_name { get; set; }
        public string action_type { get; set; }
    
        public virtual manager_role manager_role { get; set; }
    }
}
