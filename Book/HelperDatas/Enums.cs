﻿

  namespace HelperData;
 
    public class Enums
    {
    public enum UserType
    {
        Admin = 2,
        Restaurant,
        Customer,
        RestaurantUser,
    }
    public enum PaymentType
    {
        Cash = 1,
        BCoin = 2,
        Credit = 3,

    }
    public enum OrderStatus
    {
        PreOrder = 1,
        Pending = 2, //Check Out
        NewOrder = 7, // when user checkout it sets the status New Order
        InProcess = 3,
        Cancled = 5,
        Delivered = 4,
        Served = 8,
        Billed = 6,
        Paid = 9,
    }
 
    public enum SourceType
    {
        Promotion = 1,
        Order = 2,
        Jobs = 3,
    }
    public enum OrderNotification
    {
        Order_is_in_Process = 3,
        Ready_to_Deliver = 4,
        Ready_to_Serve = 8,
        Billed = 6,
        Paid = 9,
        Order_is_Canceled = 5,
        Your_Order_Has_Been_Placed = 7,
    }
    public enum OrderType
    {
        DineIn = 1,
        TakeAway = 2,
        Delivery = 3,
        Self_Pickup = 4
    }

    public enum OrderAction
    {
        Request = 1,
        Accepted = 2,
        Rejected = 3,
    }



    public enum ActionMode
    {
        Added = 1,
        Updated,
        Deleted
    }

    public enum ClaimType
    {
        UserId = 1,
        Name,
        UserTypeId,
        RestaurantBranchId,
            ImageUrl,
            Email,
            Role,
    }

    public enum EnquiryStatus
    {
        Open = 1,
        Confirmed,
        Closed,
        OnHold,
    }



    public enum AgentType
    {
        ExternalAgent = 1,
        LCOpener,
    }
    public enum AgentSide
    {
        BuyerSideAgent = 1,
        SellerSideAgent,
    }
    public enum Department
    {
        Yarn_Export = 1,
        Fabric_Export = 2,
        Yarn_Local = 3,
        Fabric_Local = 5,
        Home_Textile_Garment = 6,
    }
    public enum FabcotBranch
    {
        [Description("Aurangzeb Block Office, 133 New Garden Town, Lahore, Pakistan.")]
        Fabcot_Local = 1,
        [Description("Flexi Office ,RAKEZ Business ZONE F-Z RAK , United Arab Emirates.")]
        Fabcot_International_FZE,
    }
    public enum DocUserRole
    {
        DepartmentHead = 1,
        SalesOfficer,
        FollowUp,
    }

    public enum RestaurantUserRole
    {
        Owner = 1,
        Manager,
        Waiter
    }

    public enum Distance
    {
        Less_Than_3_Km = 3,
        Between_3_To_6_Km = 6,
        More_Than_6_Km = 20,
    }

    public enum SearchType
    {
        Dish = 1,
        Restaurant = 2
    }

    public enum CardType
    {
        Visa = 1,

    }

    public enum OrderDetailAdditionalType
    {
        SoftDrink = 1,
        Cheez = 2,
        linkedItem = 3
    }

}
public static class AppRoles
{
    public const string All = "SuperAdmin, Admin, Manager, SalesExecutive";
    public const string SuperAdmin_Admin = "SuperAdmin, Admin";
    public const string Manager_SalesExecutive = "Manager, SalesExecutive";
}

 
 
