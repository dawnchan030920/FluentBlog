using FluentBlog.Store.Page.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;

namespace FluentBlog.Store.Page
{
	public static class PageReducer
	{
		[ReducerMethod]
		public static PageState OnPageReset(PageState state, PageResetAction action)
		{
			return state with
			{
				CurrentPage = action.Page,
				CurrentSubPages = null
			};
		}

		[ReducerMethod]
		public static PageState OnSubPageSet(PageState state, SubPageSetAction action)
		{
			return state with
			{
				CurrentSubPages = action.Datas
			};
		}

		[ReducerMethod]
		public static PageState OnDataSet(PageState state, DataSetAction action)
		{
			return state with
			{
				CurrentPage = action.Page,
				CurrentSubPages = action.SubPages
			};
		}

		[ReducerMethod(typeof(DataClearAction))]
		public static PageState OnDataClear(PageState state)
		{
			return state with
			{
				CurrentPage = null,
				CurrentSubPages = null
			};
		}
	}
}
