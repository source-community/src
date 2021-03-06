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
    
    public partial class orders
    {
        public orders()
        {
            this.order_goods = new HashSet<order_goods>();
        }
    
        public int id { get; set; }
        public string order_no { get; set; }
        public string trade_no { get; set; }
        public Nullable<int> user_id { get; set; }
        public string user_name { get; set; }
        public Nullable<int> payment_id { get; set; }
        public Nullable<decimal> payment_fee { get; set; }
        public Nullable<byte> payment_status { get; set; }
        public Nullable<System.DateTime> payment_time { get; set; }
        public Nullable<int> express_id { get; set; }
        public string express_no { get; set; }
        public Nullable<decimal> express_fee { get; set; }
        public Nullable<byte> express_status { get; set; }
        public Nullable<System.DateTime> express_time { get; set; }
        public string accept_name { get; set; }
        public string post_code { get; set; }
        public string telphone { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string area { get; set; }
        public string address { get; set; }
        public string message { get; set; }
        public string remark { get; set; }
        public Nullable<byte> is_invoice { get; set; }
        public string invoice_title { get; set; }
        public Nullable<decimal> invoice_taxes { get; set; }
        public Nullable<decimal> payable_amount { get; set; }
        public Nullable<decimal> real_amount { get; set; }
        public Nullable<decimal> order_amount { get; set; }
        public Nullable<int> point { get; set; }
        public Nullable<byte> status { get; set; }
        public Nullable<System.DateTime> add_time { get; set; }
        public Nullable<System.DateTime> confirm_time { get; set; }
        public Nullable<System.DateTime> complete_time { get; set; }
    
        public virtual ICollection<order_goods> order_goods { get; set; }
    }
}
