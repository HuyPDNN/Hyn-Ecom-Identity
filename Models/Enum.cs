namespace HynEcom.IdentityServer.Models
{
    public static class Enum
    {
        public class Function
        {
            public class Base
            {
                public const string fn_hard_delete_multiple_dynamic_table = "SELECT * from identity.fn_hard_delete_multiple_dynamic_table(@db_schema, @tbl_name, @ids)";

                public const string fn_soft_delete_multiple_dynamic_table = "SELECT * from identity.fn_soft_delete_multiple_dynamic_table(@db_schema, @tbl_name, @ids)";
            }

            public class BusinessObject
            {
                public const string fn_insert_business_object = "SELECT * FROM fn_insert_business_object(@_id, @_code, @_name, @_date_of_birth, @_email, @_phone, @_address, @_description, @_is_active, @_is_deleted)";

                public const string fn_gets_business_object_for_pages = "SELECT * from identity.fn_gets_business_object_for_pages(@keyword, @skipcount, @maxresultcount)";

                public const string fn_gets_business_object_by_ids = "SELECT * from identity.fn_gets_business_object_by_ids(@ids)";
            }
        }
    }
}
