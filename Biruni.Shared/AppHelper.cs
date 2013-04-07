using System;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biruni.Shared
{
    public static class AppHelper
    {
        public static int appUserID;
        public static string appUserName;
        public static string appRoleName;
        public static string dbServer;
        public static string dbName;
        public static string dbUser;
        public static string dbPassword;
        public static string visualStyle;

        public static SqlConnection GetDbConnection()
        {
            return GetDbConnection(dbServer, dbName, dbUser, dbPassword);
        }

        private static SqlConnection GetDbConnection(string dbServer, string dbName, string dbUser, string dbPassword)
        {
            SqlConnectionStringBuilder cnbuild = new SqlConnectionStringBuilder();
            cnbuild.DataSource = dbServer;
            cnbuild.InitialCatalog = dbName;
            cnbuild.UserID = dbUser;
            cnbuild.Password = "getdown";
            return new SqlConnection(cnbuild.ConnectionString);
        }

        public static void ApplyVisualStyle(Control.ControlCollection Controls)
        {
            ApplyVisualStyle(Controls, visualStyle);
        }

        public static void ApplyVisualStyle(Control.ControlCollection Controls, string visualStyle)
        {
            foreach (Control ctl in Controls)
            {
                // apply visual style to child controls (if any)
                if (ctl.Controls != null)
                    ApplyVisualStyle(ctl.Controls, visualStyle);

                // apply visual style for this control
                switch (visualStyle)
                {
                    case VisualStyles.VISUAL_STYLE_BLUE:
                        switch (ctl.GetType().ToString())
                        {
                            case "C1.Win.C1Input.C1Button":
                                (ctl as C1.Win.C1Input.C1Button).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1DateEdit":
                                (ctl as C1.Win.C1Input.C1DateEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1DbNavigator":
                                (ctl as C1.Win.C1Input.C1DbNavigator).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1DropDownControl":
                                (ctl as C1.Win.C1Input.C1DropDownControl).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1Label":
                                (ctl as C1.Win.C1Input.C1Label).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1NumericEdit":
                                (ctl as C1.Win.C1Input.C1NumericEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1TextBox":
                                (ctl as C1.Win.C1Input.C1TextBox).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Command.C1DockingTab":
                                (ctl as C1.Win.C1Command.C1DockingTab).VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1FlexGrid.C1FlexGrid":
                                (ctl as C1.Win.C1FlexGrid.C1FlexGrid).VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBDropdown":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBDropdown).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBGrid":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBGrid).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1List.C1Combo":
                                (ctl as C1.Win.C1List.C1Combo).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1List.C1List":
                                (ctl as C1.Win.C1List.C1List).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
                                break;
                        }
                        break;
                    case VisualStyles.VISUAL_STYLE_SILVER:
                        switch (ctl.GetType().ToString())
                        {
                            case "C1.Win.C1Input.C1Button":
                                (ctl as C1.Win.C1Input.C1Button).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1Input.C1DateEdit":
                                (ctl as C1.Win.C1Input.C1DateEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1Input.C1DbNavigator":
                                (ctl as C1.Win.C1Input.C1DbNavigator).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1Input.C1DropDownControl":
                                (ctl as C1.Win.C1Input.C1DropDownControl).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1Input.C1Label":
                                (ctl as C1.Win.C1Input.C1Label).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1Input.C1NumericEdit":
                                (ctl as C1.Win.C1Input.C1NumericEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1Input.C1TextBox":
                                (ctl as C1.Win.C1Input.C1TextBox).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1Command.C1DockingTab":
                                (ctl as C1.Win.C1Command.C1DockingTab).VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1FlexGrid.C1FlexGrid":
                                (ctl as C1.Win.C1FlexGrid.C1FlexGrid).VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBDropdown":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBDropdown).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBGrid":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBGrid).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1List.C1Combo":
                                (ctl as C1.Win.C1List.C1Combo).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1List.C1List":
                                (ctl as C1.Win.C1List.C1List).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver;
                                break;
                        }
                        break;
                    case VisualStyles.VISUAL_STYLE_BLACK:
                        switch (ctl.GetType().ToString())
                        {
                            case "C1.Win.C1Input.C1Button":
                                (ctl as C1.Win.C1Input.C1Button).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1Input.C1DateEdit":
                                (ctl as C1.Win.C1Input.C1DateEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1Input.C1DbNavigator":
                                (ctl as C1.Win.C1Input.C1DbNavigator).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1Input.C1DropDownControl":
                                (ctl as C1.Win.C1Input.C1DropDownControl).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1Input.C1Label":
                                (ctl as C1.Win.C1Input.C1Label).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1Input.C1NumericEdit":
                                (ctl as C1.Win.C1Input.C1NumericEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1Input.C1TextBox":
                                (ctl as C1.Win.C1Input.C1TextBox).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1Command.C1DockingTab":
                                (ctl as C1.Win.C1Command.C1DockingTab).VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1FlexGrid.C1FlexGrid":
                                (ctl as C1.Win.C1FlexGrid.C1FlexGrid).VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBDropdown":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBDropdown).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBGrid":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBGrid).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1List.C1Combo":
                                (ctl as C1.Win.C1List.C1Combo).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1List.C1List":
                                (ctl as C1.Win.C1List.C1List).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Black;
                                break;
                        }
                        break;
                    case VisualStyles.VISUAL_STYLE_BLUE10:
                        switch (ctl.GetType().ToString())
                        {
                            case "C1.Win.C1Input.C1Button":
                                (ctl as C1.Win.C1Input.C1Button).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
                                break;
                            case "C1.Win.C1Input.C1DateEdit":
                                (ctl as C1.Win.C1Input.C1DateEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
                                break;
                            case "C1.Win.C1Input.C1DbNavigator":
                                (ctl as C1.Win.C1Input.C1DbNavigator).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
                                break;
                            case "C1.Win.C1Input.C1DropDownControl":
                                (ctl as C1.Win.C1Input.C1DropDownControl).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
                                break;
                            case "C1.Win.C1Input.C1Label":
                                (ctl as C1.Win.C1Input.C1Label).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
                                break;
                            case "C1.Win.C1Input.C1NumericEdit":
                                (ctl as C1.Win.C1Input.C1NumericEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
                                break;
                            case "C1.Win.C1Input.C1TextBox":
                                (ctl as C1.Win.C1Input.C1TextBox).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
                                break;
                            case "C1.Win.C1Command.C1DockingTab":
                                (ctl as C1.Win.C1Command.C1DockingTab).VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue;
                                break;
                            case "C1.Win.C1FlexGrid.C1FlexGrid":
                                (ctl as C1.Win.C1FlexGrid.C1FlexGrid).VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBDropdown":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBDropdown).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBGrid":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBGrid).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1List.C1Combo":
                                (ctl as C1.Win.C1List.C1Combo).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1List.C1List":
                                (ctl as C1.Win.C1List.C1List).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
                                break;
                        }
                        break;
                    case VisualStyles.VISUAL_STYLE_SILVER10:
                        switch (ctl.GetType().ToString())
                        {
                            case "C1.Win.C1Input.C1Button":
                                (ctl as C1.Win.C1Input.C1Button).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
                                break;
                            case "C1.Win.C1Input.C1DateEdit":
                                (ctl as C1.Win.C1Input.C1DateEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
                                break;
                            case "C1.Win.C1Input.C1DbNavigator":
                                (ctl as C1.Win.C1Input.C1DbNavigator).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
                                break;
                            case "C1.Win.C1Input.C1DropDownControl":
                                (ctl as C1.Win.C1Input.C1DropDownControl).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
                                break;
                            case "C1.Win.C1Input.C1Label":
                                (ctl as C1.Win.C1Input.C1Label).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
                                break;
                            case "C1.Win.C1Input.C1NumericEdit":
                                (ctl as C1.Win.C1Input.C1NumericEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
                                break;
                            case "C1.Win.C1Input.C1TextBox":
                                (ctl as C1.Win.C1Input.C1TextBox).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
                                break;
                            case "C1.Win.C1Command.C1DockingTab":
                                (ctl as C1.Win.C1Command.C1DockingTab).VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Silver;
                                break;
                            case "C1.Win.C1FlexGrid.C1FlexGrid":
                                (ctl as C1.Win.C1FlexGrid.C1FlexGrid).VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBDropdown":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBDropdown).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBGrid":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBGrid).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1List.C1Combo":
                                (ctl as C1.Win.C1List.C1Combo).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver;
                                break;
                            case "C1.Win.C1List.C1List":
                                (ctl as C1.Win.C1List.C1List).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver;
                                break;
                        }
                        break;
                    case VisualStyles.VISUAL_STYLE_BLACK10:
                    case VisualStyles.VISUAL_STYLE_WINDOWS7:
                        switch (ctl.GetType().ToString())
                        {
                            case "C1.Win.C1Input.C1Button":
                                (ctl as C1.Win.C1Input.C1Button).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
                                break;
                            case "C1.Win.C1Input.C1DateEdit":
                                (ctl as C1.Win.C1Input.C1DateEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
                                break;
                            case "C1.Win.C1Input.C1DbNavigator":
                                (ctl as C1.Win.C1Input.C1DbNavigator).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
                                break;
                            case "C1.Win.C1Input.C1DropDownControl":
                                (ctl as C1.Win.C1Input.C1DropDownControl).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
                                break;
                            case "C1.Win.C1Input.C1Label":
                                (ctl as C1.Win.C1Input.C1Label).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
                                break;
                            case "C1.Win.C1Input.C1NumericEdit":
                                (ctl as C1.Win.C1Input.C1NumericEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
                                break;
                            case "C1.Win.C1Input.C1TextBox":
                                (ctl as C1.Win.C1Input.C1TextBox).VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
                                break;
                            case "C1.Win.C1Command.C1DockingTab":
                                (ctl as C1.Win.C1Command.C1DockingTab).VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Black;
                                break;
                            case "C1.Win.C1FlexGrid.C1FlexGrid":
                                (ctl as C1.Win.C1FlexGrid.C1FlexGrid).VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBDropdown":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBDropdown).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBGrid":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBGrid).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1List.C1Combo":
                                (ctl as C1.Win.C1List.C1Combo).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Black;
                                break;
                            case "C1.Win.C1List.C1List":
                                (ctl as C1.Win.C1List.C1List).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Black;
                                break;
                        }
                        break;
                    default:
                        switch (ctl.GetType().ToString())
                        {
                            case "C1.Win.C1Input.C1Button":
                                (ctl as C1.Win.C1Input.C1Button).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1DateEdit":
                                (ctl as C1.Win.C1Input.C1DateEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1DbNavigator":
                                (ctl as C1.Win.C1Input.C1DbNavigator).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1DropDownControl":
                                (ctl as C1.Win.C1Input.C1DropDownControl).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1Label":
                                (ctl as C1.Win.C1Input.C1Label).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1NumericEdit":
                                (ctl as C1.Win.C1Input.C1NumericEdit).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Input.C1TextBox":
                                (ctl as C1.Win.C1Input.C1TextBox).VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1Command.C1DockingTab":
                                (ctl as C1.Win.C1Command.C1DockingTab).VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1FlexGrid.C1FlexGrid":
                                (ctl as C1.Win.C1FlexGrid.C1FlexGrid).VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBDropdown":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBDropdown).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1TrueDBGrid.C1TrueDBGrid":
                                (ctl as C1.Win.C1TrueDBGrid.C1TrueDBGrid).VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1List.C1Combo":
                                (ctl as C1.Win.C1List.C1Combo).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
                                break;
                            case "C1.Win.C1List.C1List":
                                (ctl as C1.Win.C1List.C1List).VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
                                break;
                        }
                        break;
                }
            }
        }

        public static void ApplyFormStyle(C1.Win.C1Ribbon.C1RibbonForm fx)
        {
            ApplyFormStyle(fx, visualStyle);
        }

        public static void ApplyFormStyle(C1.Win.C1Ribbon.C1RibbonForm fx, string visualStyle)
        {
            // apply visual style for this control
            switch (visualStyle)
            {
                case VisualStyles.VISUAL_STYLE_BLUE:
                    fx.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Blue;
                    fx.BackColor = System.Drawing.Color.FromArgb(234, 242, 251);
                    break;
                case VisualStyles.VISUAL_STYLE_SILVER:
                    fx.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Silver;
                    fx.BackColor = System.Drawing.Color.FromArgb(232, 234, 236);
                    break;
                case VisualStyles.VISUAL_STYLE_BLACK:
                    fx.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Black;
                    fx.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
                    break;
                case VisualStyles.VISUAL_STYLE_BLUE10:
                    fx.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Blue;
                    fx.BackColor = System.Drawing.Color.FromArgb(234, 242, 255);
                    break;
                case VisualStyles.VISUAL_STYLE_SILVER10:
                    fx.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Silver;
                    fx.BackColor = System.Drawing.Color.FromArgb(232, 234, 236);
                    break;
                case VisualStyles.VISUAL_STYLE_BLACK10:
                    fx.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Black;
                    fx.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
                    break;
                case VisualStyles.VISUAL_STYLE_WINDOWS7:
                    fx.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Windows7;
                    fx.BackColor = System.Drawing.Color.FromArgb(234, 242, 255);
                    break;
                default:
                    fx.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Windows7;
                    fx.BackColor = System.Drawing.Color.FromArgb(234, 242, 255);
                    break;
            }
        }


        public static IDictionary TransactionTypeDataMap()
        {
            Hashtable dtMap = new Hashtable();
            dtMap.Add(0, "Loose");
            dtMap.Add(1, "Carton");
            dtMap.Add(2, "Scheme");
            return dtMap;
        }
    }

    public static class VisualStyles
    {
        public const string VISUAL_STYLE_BLUE = "Blue";
        public const string VISUAL_STYLE_SILVER = "Silver";
        public const string VISUAL_STYLE_BLACK = "Black";
        public const string VISUAL_STYLE_BLUE10 = "Blue 2010";
        public const string VISUAL_STYLE_SILVER10 = "Silver 2010";
        public const string VISUAL_STYLE_BLACK10 = "Black 2010";
        public const string VISUAL_STYLE_WINDOWS7 = "Windows7";
    }

    public static class TransactionTypes
    {
        public const string TX_SALES_ORDER = "SO";
        public const string TX_SALES_QUOTATION = "SQ";
        public const string TX_PURCHASE_ORDER = "PO";
        public const string TX_DELIVERY_ORDER = "DO";
        public const string TX_RECEIVING_REPORT = "RR";
        public const string TX_INVENTORY_ADJUSTMENT = "IA";
        public const string TX_SALES_INVOICE = "SI";
        public const string TX_SALES_PAYMENT = "SP";
        public const string TX_PURCHASE_INVOICE = "PI";
        public const string TX_PURCHASE_PAYMENT = "PP";
        public const string TX_BEGINBALANCE_CUSTOMER = "BC";
        public const string TX_BEGINBALANCE_VENDOR = "BV";
        
    }
}
