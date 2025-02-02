﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_FrameWorkk.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyQuanCafe1Entities1 : DbContext
    {
        public QuanLyQuanCafe1Entities1()
            : base("name=QuanLyQuanCafe1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillInfo> BillInfoes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<TableFood> TableFoods { get; set; }
        public virtual DbSet<ListAccount> ListAccounts { get; set; }
        public virtual DbSet<View_EmployeeActiv> View_EmployeeActiv { get; set; }
    
        public virtual int AddTable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddTable");
        }
    
        public virtual int DeleteEmploy(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteEmploy", idParameter);
        }
    
        public virtual int DeleteTable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTable");
        }
    
        [DbFunction("QuanLyQuanCafe1Entities1", "FN_GetListIncomeByDate")]
        public virtual IQueryable<FN_GetListIncomeByDate_Result> FN_GetListIncomeByDate(Nullable<System.DateTime> datein, Nullable<System.DateTime> dateout)
        {
            var dateinParameter = datein.HasValue ?
                new ObjectParameter("datein", datein) :
                new ObjectParameter("datein", typeof(System.DateTime));
    
            var dateoutParameter = dateout.HasValue ?
                new ObjectParameter("dateout", dateout) :
                new ObjectParameter("dateout", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FN_GetListIncomeByDate_Result>("[QuanLyQuanCafe1Entities1].[FN_GetListIncomeByDate](@datein, @dateout)", dateinParameter, dateoutParameter);
        }
    
        [DbFunction("QuanLyQuanCafe1Entities1", "FN_GetMenu")]
        public virtual IQueryable<FN_GetMenu_Result> FN_GetMenu(Nullable<int> id1)
        {
            var id1Parameter = id1.HasValue ?
                new ObjectParameter("id1", id1) :
                new ObjectParameter("id1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FN_GetMenu_Result>("[QuanLyQuanCafe1Entities1].[FN_GetMenu](@id1)", id1Parameter);
        }
    
        [DbFunction("QuanLyQuanCafe1Entities1", "FN_ListAccount")]
        public virtual IQueryable<FN_ListAccount_Result> FN_ListAccount(Nullable<int> type)
        {
            var typeParameter = type.HasValue ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FN_ListAccount_Result>("[QuanLyQuanCafe1Entities1].[FN_ListAccount](@type)", typeParameter);
        }
    
        public virtual int GanQuyenNhanVien(Nullable<int> type, string loginname)
        {
            var typeParameter = type.HasValue ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(int));
    
            var loginnameParameter = loginname != null ?
                new ObjectParameter("Loginname", loginname) :
                new ObjectParameter("Loginname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GanQuyenNhanVien", typeParameter, loginnameParameter);
        }
    
        public virtual ObjectResult<GetListByDate_Result> GetListByDate(Nullable<System.DateTime> datein, Nullable<System.DateTime> dateout)
        {
            var dateinParameter = datein.HasValue ?
                new ObjectParameter("datein", datein) :
                new ObjectParameter("datein", typeof(System.DateTime));
    
            var dateoutParameter = dateout.HasValue ?
                new ObjectParameter("dateout", dateout) :
                new ObjectParameter("dateout", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetListByDate_Result>("GetListByDate", dateinParameter, dateoutParameter);
        }
    
        public virtual int ThemDangNhap(string loginName, string password, Nullable<int> type)
        {
            var loginNameParameter = loginName != null ?
                new ObjectParameter("LoginName", loginName) :
                new ObjectParameter("LoginName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemDangNhap", loginNameParameter, passwordParameter, typeParameter);
        }
    
        public virtual ObjectResult<UpdateAccount_Result> UpdateAccount(string username, string displayname, string password, string newPasword)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var displaynameParameter = displayname != null ?
                new ObjectParameter("displayname", displayname) :
                new ObjectParameter("displayname", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var newPaswordParameter = newPasword != null ?
                new ObjectParameter("newPasword", newPasword) :
                new ObjectParameter("newPasword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateAccount_Result>("UpdateAccount", usernameParameter, displaynameParameter, passwordParameter, newPaswordParameter);
        }
    
        public virtual int USP_CaculateWorkingTime(Nullable<double> totaltime)
        {
            var totaltimeParameter = totaltime.HasValue ?
                new ObjectParameter("totaltime", totaltime) :
                new ObjectParameter("totaltime", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_CaculateWorkingTime", totaltimeParameter);
        }
    
        public virtual int USP_EmployeeWorking(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_EmployeeWorking", idParameter);
        }
    
        public virtual ObjectResult<USP_GetAccountByUserName_Result> USP_GetAccountByUserName(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetAccountByUserName_Result>("USP_GetAccountByUserName", usernameParameter);
        }
    
        public virtual ObjectResult<USP_GetBill_Result> USP_GetBill(Nullable<int> idbill)
        {
            var idbillParameter = idbill.HasValue ?
                new ObjectParameter("idbill", idbill) :
                new ObjectParameter("idbill", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetBill_Result>("USP_GetBill", idbillParameter);
        }
    
        public virtual ObjectResult<USP_GetLogin_Result> USP_GetLogin(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetLogin_Result>("USP_GetLogin", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<USP_GetMenu_Result> USP_GetMenu(Nullable<int> id1)
        {
            var id1Parameter = id1.HasValue ?
                new ObjectParameter("id1", id1) :
                new ObjectParameter("id1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetMenu_Result>("USP_GetMenu", id1Parameter);
        }
    
        public virtual ObjectResult<USP_GetTableList_Result> USP_GetTableList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetTableList_Result>("USP_GetTableList");
        }
    
        public virtual ObjectResult<USP_GetUnCheckTable_Result> USP_GetUnCheckTable(Nullable<int> idtable)
        {
            var idtableParameter = idtable.HasValue ?
                new ObjectParameter("idtable", idtable) :
                new ObjectParameter("idtable", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetUnCheckTable_Result>("USP_GetUnCheckTable", idtableParameter);
        }
    
        public virtual int USP_InsertBill(Nullable<int> idTable)
        {
            var idTableParameter = idTable.HasValue ?
                new ObjectParameter("idTable", idTable) :
                new ObjectParameter("idTable", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertBill", idTableParameter);
        }
    
        public virtual int USP_InsertBillInfo(Nullable<int> idBill, Nullable<int> idFood, Nullable<int> count)
        {
            var idBillParameter = idBill.HasValue ?
                new ObjectParameter("idBill", idBill) :
                new ObjectParameter("idBill", typeof(int));
    
            var idFoodParameter = idFood.HasValue ?
                new ObjectParameter("idFood", idFood) :
                new ObjectParameter("idFood", typeof(int));
    
            var countParameter = count.HasValue ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertBillInfo", idBillParameter, idFoodParameter, countParameter);
        }
    
        public virtual int USP_ThanhToanLuong(Nullable<int> idEmployee)
        {
            var idEmployeeParameter = idEmployee.HasValue ?
                new ObjectParameter("idEmployee", idEmployee) :
                new ObjectParameter("idEmployee", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ThanhToanLuong", idEmployeeParameter);
        }
    
        public virtual int USP_ThemNhanVien1(string hoTen, Nullable<System.DateTime> ngaySinh)
        {
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("NgaySinh", ngaySinh) :
                new ObjectParameter("NgaySinh", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ThemNhanVien1", hoTenParameter, ngaySinhParameter);
        }
    
        public virtual int USP_XoaDangNhap(string loginName, string password, Nullable<int> type)
        {
            var loginNameParameter = loginName != null ?
                new ObjectParameter("LoginName", loginName) :
                new ObjectParameter("LoginName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_XoaDangNhap", loginNameParameter, passwordParameter, typeParameter);
        }
    }
}
