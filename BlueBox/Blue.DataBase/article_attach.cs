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
    
    public partial class article_attach
    {
        public int id { get; set; }
        public Nullable<int> article_id { get; set; }
        public string file_name { get; set; }
        public string file_path { get; set; }
        public Nullable<int> file_size { get; set; }
        public string file_ext { get; set; }
        public Nullable<int> down_num { get; set; }
        public Nullable<int> point { get; set; }
        public Nullable<System.DateTime> add_time { get; set; }
    }
}
