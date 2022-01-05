using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using GenericGridComponent_RCL;
using System;

namespace GenericGridComponent_RCL
{
    public interface IGrid
    {
        bool AllowPaging { get; set; }
        int CurrentPage { get; set; }
        RenderFragment GridColumns { get; set; }
        RenderFragment GridSearchSetting { get; set; }
        int PageSize { get; set; }
        bool ReloadList { get; set; }
        bool ShowMessageDialogue { get; set; }
        RenderFragment TemplateGrid { get; set; }
        int TotalPages { get; set; }
        void GetPageSize(int pagesize);
        void AddColumn(IGridColumn column);
        void AddTemplate(ITemplate temp);
        Task CalculatePage(int pagesize);
        void CloseCurrentFilter(bool value);
        void NavigatePageTo(string btnDirection);
 
        void UpdateListAsPerPage(int pageNumber = 0);
        List<Object> DataSource { get; set; }
        List<Object> GetTheRecord();
        void RefreshGrid(List<Object> itemlist);
        bool AllowSorting { get; set; }
    }

   
}