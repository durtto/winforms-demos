#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using System.Threading;
using Syncfusion.Windows.Forms.Grid.Grouping.Localization;
namespace DynamicFilter
{
    class Localizer : ILocalizationProvider
    {
        bool comparerList = false;
        bool recordNavigBar = false;
        bool office2007Filter = false;
        bool fieldChooser = false;
        public void getstring(bool s, bool recordNavig, bool office2007, bool fieldChooser)
        {
            comparerList = s;
            recordNavigBar = recordNavig;
            office2007Filter = office2007;
            this.fieldChooser = fieldChooser;
        }
        public string GetLocalizedString(System.Globalization.CultureInfo culture, string name,object obj)
        {
            switch (name)
            {
                case DynamicFilterResourceIdentifiers.StartsWith:
                    if (comparerList)
                        return "empieza con";
                    else
                        return "StartsWith";
                case DynamicFilterResourceIdentifiers.EndsWith:
                    if (comparerList)
                        return "termina con";
                    else
                        return "EndsWith";
                case DynamicFilterResourceIdentifiers.Equal:
                    if (comparerList)
                        return "es igual a";
                    else
                        return "Equals";
                case DynamicFilterResourceIdentifiers.GreaterThan:
                    if (comparerList)
                        return "mayor que";
                    else
                        return "GreaterThan";
                case DynamicFilterResourceIdentifiers.GreaterThanOrEqualTo:
                    if (comparerList)
                        return "Mayor o igual a";
                    else
                        return "GreaterThanOrEqualTo";
                case DynamicFilterResourceIdentifiers.LessThan:
                    if (comparerList)
                        return "menos que";
                    else
                        return "LessThan";
                case DynamicFilterResourceIdentifiers.LessThanOrEqualTo:
                    if (comparerList)
                        return "Menor o igual a";
                    else
                        return "LessThanOrEqualTo";
                case DynamicFilterResourceIdentifiers.Like:
                    if (comparerList)
                        return "como";
                    else
                        return "Like";
                case DynamicFilterResourceIdentifiers.Match:
                    if (comparerList)
                        return "partido";
                    else
                        return "Match";
                case DynamicFilterResourceIdentifiers.NotEquals:
                    if (comparerList)
                        return "no es igual";
                    else
                        return "NotEqual";
                case DynamicFilterResourceIdentifiers.ExpressionMATCH:
                    if (comparerList)
                        return "expresión de coincidencia";
                    else
                        return "ExpressionMatch";

                case GroupingResourceIdentifiers.RecordNavigatorOF:
                    if (recordNavigBar)
                        return "von";
                    else
                        return "Of";

                // DropDown filter item 

                case DynamicFilterResourceIdentifiers.All:
                    return "(todo)";
                case DynamicFilterResourceIdentifiers.Custom:
                    return "(costumbre...)";
                case DynamicFilterResourceIdentifiers.Empty:
                    return "(vacío)";

                //Drag group column
                case GroupingResourceIdentifiers.DragColumnHeaderHereText:
                    return "Ziehen Sie die Spaltenüberschrift";

                case DynamicFilterResourceIdentifiers.FieldChooser:
                    if (fieldChooser)
                        return "Feldauswahl";
                    else
                        return "FieldChooser";

                case DynamicFilterResourceIdentifiers.FieldDialogBox:
                    if (fieldChooser)
                        return "Dialogfeld Feld";
                    else
                        return "FieldChooser";
                case DynamicFilterResourceIdentifiers.FieldTreeDialogBox:
                    if (fieldChooser)
                        return "Feld Baum Dialogfeld";
                    else
                        return "FieldChooser";               

                case DynamicFilterResourceIdentifiers.SelectAll:
                    if (office2007Filter)
                        return "Alle auswählen";
                    else
                        return "SelectAll";
                case DynamicFilterResourceIdentifiers.SortAtoZ:
                    if (office2007Filter)
                        return "&SortierenAbisZ";
                    else
                        return "&SortAtoZ";
                case DynamicFilterResourceIdentifiers.SortZtoA:
                    if (office2007Filter)
                        return "S&ortierenZbisA";
                    else
                        return "S&ortZtoA";
                case DynamicFilterResourceIdentifiers.TextFilters:
                    if (office2007Filter)
                        return "&Text-Filter";
                    else
                        return "TextFilters";
                case DynamicFilterResourceIdentifiers.ClearFilterFrom:
                    if (office2007Filter)
                        return "&Von Filterstundenzähler";
                    else
                        return "ClearFilterFrom";
                case DynamicFilterResourceIdentifiers.ShowRowsWhere:
                    if (office2007Filter)
                        return "Zeigt die Zeilen, in denen";
                    else
                        return "Shows the rows where:";
                case DynamicFilterResourceIdentifiers.CustomAutoFilter:
                    if (office2007Filter)
                        return "Benutzerdefinierte Auto Filter";
                    else
                        return "CustomAutoFilter";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterLessthan:
                    if (office2007Filter)
                        return "Kleiner als";
                    else
                        return "LessThan";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterEqual:
                    if (office2007Filter)
                        return "Equal";
                    else
                        return "Equal";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterNotequal:
                    if (office2007Filter)
                        return "notEqual";
                    else
                        return "NotEqual";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterGreaterthan:
                    if (office2007Filter)
                        return "Größer als";
                    else
                        return "Greaterthan";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterGreaterthanOrEqual:
                    if (office2007Filter)
                        return "Größer oder gleich";
                    else
                        return "GreaterthanOrEqual";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterlessthanOrEqual:
                    if (office2007Filter)
                        return "LessThan oder-gleich-";
                    else
                        return "LessthanOrEqual";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterLike:
                    if (office2007Filter)
                        return "wie";
                    else
                        return "Like";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterMatch:
                    if (office2007Filter)
                        return "Spiel";
                    else
                        return "Match";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterBeginsWith:
                    if (office2007Filter)
                        return "Beginntmit";
                    else
                        return "BeginsWith";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterEndsWith:
                    if (office2007Filter)
                        return "Endetmit";
                    else
                        return "EndsWith";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterCancel:
                    if (office2007Filter)
                        return "stornieren";
                    else
                        return "Cancel";
                case DynamicFilterResourceIdentifiers.CustomAutoFilterOK:
                    if (office2007Filter)
                        return "OK";
                    else
                        return "Ok";
                case DynamicFilterResourceIdentifiers.Office2007FilterEquals:
                    if (office2007Filter)
                        return "Equals";
                    else
                        return "Equals";
                case DynamicFilterResourceIdentifiers.Office2007FilterNotEquals:
                    if (office2007Filter)
                        return "Nicht gleich";
                    else
                        return "NotEqual";
                case DynamicFilterResourceIdentifiers.Office2007FilterBeginswith:
                    if (office2007Filter)
                        return "Beginntmit";
                    else
                        return "BeginsWith";
                case DynamicFilterResourceIdentifiers.Office2007FilterEndswith:
                    if (office2007Filter)
                        return "Endetmit";
                    else
                        return "Endswith";
                case DynamicFilterResourceIdentifiers.Office2007FilterContains:
                    if (office2007Filter)
                        return "enthält";
                    else
                        return "Contains";
                case DynamicFilterResourceIdentifiers.Office2007FilterCustomFilter:
                    if (office2007Filter)
                        return "Benutzerdefinierte Filter";
                    else
                        return "CustomFilter";
                case DynamicFilterResourceIdentifiers.Office2007FilterCustomFilterand:
                    if (office2007Filter)
                        return "und";
                    else
                        return "And";
                case DynamicFilterResourceIdentifiers.Office2007FilterCustomFilteror:
                    if (office2007Filter)
                        return "oder";
                    else
                        return "Or";
                default:
                    return string.Empty;
            }
        }
    }
}



