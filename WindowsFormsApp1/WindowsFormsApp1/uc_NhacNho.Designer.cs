namespace WindowsFormsApp1
{
    partial class uc_NhacNho
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.dxGoogleCalendarSync1 = new DevExpress.XtraScheduler.GoogleCalendar.DXGoogleCalendarSync(this.components);
            schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(schedulerDataStorage1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 491);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 63);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.schedulerControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1172, 428);
            this.panel3.TabIndex = 1;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek;
            this.schedulerControl1.Appearance.NavigationButton.FontStyleDelta = System.Drawing.FontStyle.Strikeout;
            this.schedulerControl1.Appearance.NavigationButton.Options.UseFont = true;
            this.schedulerControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.schedulerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.schedulerControl1.CausesValidation = false;
            this.schedulerControl1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.schedulerControl1.DataStorage = schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.DragDropMode = DevExpress.XtraScheduler.DragDropMode.Manual;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsDragDrop.AutoScrollEnabled = false;
            this.schedulerControl1.OptionsDragDrop.DragDropMode = DevExpress.XtraScheduler.DragDropMode.Manual;
            this.schedulerControl1.OptionsFlyout.SubjectAutoHeight = true;
            this.schedulerControl1.OptionsPrint.PrintPreviewFormKind = DevExpress.XtraScheduler.Printing.PrintPreviewFormKind.Ribbon;
            this.schedulerControl1.OptionsPrint.PrintStyle = DevExpress.XtraScheduler.Printing.SchedulerPrintStyleKind.Monthly;
            this.schedulerControl1.OptionsRangeControl.AllowChangeActiveView = false;
            this.schedulerControl1.OptionsRangeControl.AutoAdjustMode = false;
            this.schedulerControl1.OptionsRangeControl.AutoFormatScaleCaptions = false;
            this.schedulerControl1.OptionsRangeControl.DataDisplayType = DevExpress.XtraScheduler.RangeControlDataDisplayType.Number;
            this.schedulerControl1.OptionsView.EnableAnimation = false;
            this.schedulerControl1.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Sunday;
            this.schedulerControl1.OptionsView.NavigationButtons.NextCaption = "";
            this.schedulerControl1.OptionsView.NavigationButtons.PrevCaption = "";
            this.schedulerControl1.OptionsView.NavigationButtons.Visibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
            this.schedulerControl1.OptionsView.UseInplaceEditor2016 = DevExpress.Utils.DefaultBoolean.False;
            this.schedulerControl1.PaintStyleName = "Office2003";
            this.schedulerControl1.ResourceNavigator.Buttons.Append.Visible = false;
            this.schedulerControl1.ResourceNavigator.Buttons.EnabledAutoRepeat = false;
            this.schedulerControl1.ResourceNavigator.Buttons.First.Visible = false;
            this.schedulerControl1.ResourceNavigator.Buttons.Last.Visible = false;
            this.schedulerControl1.ResourceNavigator.Buttons.Next.Visible = false;
            this.schedulerControl1.ResourceNavigator.Buttons.NextPage.Enabled = false;
            this.schedulerControl1.ResourceNavigator.Buttons.NextPage.Visible = false;
            this.schedulerControl1.ResourceNavigator.Buttons.Prev.Enabled = false;
            this.schedulerControl1.ResourceNavigator.Buttons.Prev.Visible = false;
            this.schedulerControl1.ResourceNavigator.Buttons.PrevPage.Visible = false;
            this.schedulerControl1.ResourceNavigator.Buttons.Remove.Visible = false;
            this.schedulerControl1.ResourceNavigator.ShowToolTips = false;
            this.schedulerControl1.ResourceNavigator.Visibility = DevExpress.XtraScheduler.ResourceNavigatorVisibility.Never;
            this.schedulerControl1.Size = new System.Drawing.Size(1172, 428);
            this.schedulerControl1.Start = new System.DateTime(2019, 8, 19, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.AllDayAreaScrollBarVisible = true;
            this.schedulerControl1.Views.DayView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
            this.schedulerControl1.Views.DayView.ShowMoreButtons = false;
            this.schedulerControl1.Views.DayView.ShowWorkTimeOnly = true;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
            this.schedulerControl1.Views.FullWeekView.ShowMoreButtons = false;
            this.schedulerControl1.Views.FullWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.GanttView.AppointmentDisplayOptions.AppointmentAutoHeight = true;
            this.schedulerControl1.Views.GanttView.ShowMoreButtons = false;
            this.schedulerControl1.Views.MonthView.CompressWeekend = true;
            this.schedulerControl1.Views.MonthView.ShowMoreButtons = false;
            this.schedulerControl1.Views.TimelineView.ShowMoreButtons = false;
            this.schedulerControl1.Views.WeekView.ShowMoreButtons = false;
            this.schedulerControl1.Views.WorkWeekView.ShowMoreButtons = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.Click += new System.EventHandler(this.schedulerControl1_Click);
            // 
            // schedulerDataStorage1
            // 
            schedulerDataStorage1.EnableReminders = false;
            schedulerDataStorage1.EnableSmartFetch = false;
            schedulerDataStorage1.EnableTimeZones = false;
            schedulerDataStorage1.FetchOnVisibleResourcesChanged = false;
            // 
            // dxGoogleCalendarSync1
            // 
            this.dxGoogleCalendarSync1.CalendarId = null;
            this.dxGoogleCalendarSync1.CalendarService = null;
            this.dxGoogleCalendarSync1.Storage = null;
            // 
            // uc_NhacNho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_NhacNho";
            this.Size = new System.Drawing.Size(1172, 491);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(schedulerDataStorage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraScheduler.GoogleCalendar.DXGoogleCalendarSync dxGoogleCalendarSync1;
    }
}
