namespace HynEcom.IdentityServer.Models
{
    public static class Enum
    {
        public class Function
        {
            public class BusinessObject
            {
                public const string fn_insert_business_object = "SELECT * from identity.fn_insert_business_object()";

                public const string fn_gets_business_object_for_pages = "SELECT * from identity.fn_gets_business_object_for_pages(@keyword, @skipcount, @maxresultcount)";

                public const string fn_gets_business_object_by_ids = "SELECT * from identity.fn_gets_business_object_by_ids(@ids)";
            }

            public class Base
            {
                public const string fn_hard_delete_multiple_dynamic_table = "SELECT * from identity.fn_hard_delete_multiple_dynamic_table(@db_schema, @tbl_name, @ids)";

                public const string fn_soft_delete_multiple_dynamic_table = "SELECT * from identity.fn_soft_delete_multiple_dynamic_table(@db_schema, @tbl_name, @ids)";
            }
        }
    }
}
