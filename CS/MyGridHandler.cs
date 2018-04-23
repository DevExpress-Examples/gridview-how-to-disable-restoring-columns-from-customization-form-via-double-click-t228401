﻿// Developer Express Code Central Example:
// How to create a GridView descendant class and register it for design-time use
// 
// This is an example of a custom GridView and a custom control that inherits the
// DevExpress.XtraGrid.GridControl. Make sure to build the project prior to opening
// Form1 in the designer. Please refer to the http://www.devexpress.com/scid=A859
// Knowledge Base article for the additional information.
// In addition, you can
// refer to the examples describing how to create GridControl's View
// descendants:
// 1. http://www.devexpress.com/scid=T122347; 2.
// http://www.devexpress.com/scid=T122335; 3.
// http://www.devexpress.com/scid=T122333; 4.
// http://www.devexpress.com/scid=T122322 ;
// 5.
// http://www.devexpress.com/scid=T122275.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E900

using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace MyXtraGrid {
	public class MyGridHandler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler {
		public MyGridHandler(GridView gridView) : base(gridView) {}

		protected override void OnKeyDown(KeyEventArgs e) {
			base.OnKeyDown(e);
			if(e.KeyData == Keys.Delete && View.State == GridState.Normal)
				View.DeleteRow(View.FocusedRowHandle);
		}
	}
}