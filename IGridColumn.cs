using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace GenericGridComponent_RCL
{
    public interface IGridColumn
    {
        bool AllowFilter { get; set; }
        bool AllowSort { get; set; }
        string arrowDirection { get; set; }
        bool b { get; set; }
        // List<T> checkBoxList { get; set; }
        string GetCss();
        string Width { get; set; }
        //Func<T, string> Field { get; set; }
        List<string> FilterList { get; set; }
        int FilterType { get; set; }
        IGrid grid { get; set; }
        RenderFragment HeaderTemplate { get; set; }
        string HeaderText { get; set; }
        bool IsCheckBoxFilter { get; set; }
        bool Isfilter { get; set; }
        bool IsFilterDialogue { get; set; }
        //List<TItems> ItemList { get; set; }
        //List<TItems> Items { get; set; }
        bool ReloadList { get; set; }
        bool ShowSortArrow { get; set; }
        RenderFragment Template { get; set; }
        RenderFragment TemplateGrid { get; set; }
        Type TypeOfField { get; set; }

        void ClearFilter();
        void FilterOnCheckBoxSelection(string searchText);
        void GetFilteredItems(ChangeEventArgs changeEventArgs);
        void OnSortDirection();
        void SearchTextInFilter(string searchText);
        void ShowFilterDialogue(bool value);


    }

}