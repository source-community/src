//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blue.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class dt_payment
    {
        public int id { get; set; }
        public string title { get; set; }
        public string img_url { get; set; }
        public string remark { get; set; }
        public Nullable<byte> type { get; set; }
        public Nullable<byte> poundage_type { get; set; }
        public Nullable<decimal> poundage_amount { get; set; }
        public Nullable<int> sort_id { get; set; }
        public Nullable<byte> is_lock { get; set; }
        public string api_path { get; set; }
    }
}
