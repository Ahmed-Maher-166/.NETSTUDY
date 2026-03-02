using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumS
{
    [Flags]
    public enum PermissionCode : long
    {
        None = 0,

        // Basic
        View = 1,
        Create = 2,
        Edit = 4,
        Delete = 8,

        // Business
        Approve = 16,
        Reject = 32,
        Export = 64,
        Import = 128,

        // Financial
        ViewReports = 256,
        ManagePayments = 512,
        Refund = 1024,

        // Admin
        ManageUsers = 2048,
        ManageRoles = 4096,
        SystemSettings = 8192,

        // Composite
        Editor = View | Create | Edit,
        Manager = View | Create | Edit | Delete | Approve | Reject | ViewReports,
        Admin = View | Create | Edit | Delete |
                          Approve | Reject |
                          Export | Import |
                          ViewReports | ManagePayments | Refund |
                          ManageUsers | ManageRoles | SystemSettings,

        All = Admin
    }
}
