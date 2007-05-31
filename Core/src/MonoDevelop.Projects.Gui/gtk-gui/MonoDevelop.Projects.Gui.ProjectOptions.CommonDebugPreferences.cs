// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Projects.Gui.ProjectOptions {
    
    
    public partial class CommonDebugPreferences {
        
        private Gtk.VBox vbox1;
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment GtkAlignment;
        
        private Gtk.Table table1;
        
        private Gtk.Entry entryURL;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Entry entryCommand;
        
        private Gtk.Button buttonBrowseCommand;
        
        private Gtk.RadioButton radiobuttonCommandLine;
        
        private Gtk.RadioButton radiobuttonProject;
        
        private Gtk.RadioButton radiobuttonURL;
        
        private Gtk.Label GtkLabel4;
        
        private Gtk.Table table2;
        
        private Gtk.Entry entryArguments;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Entry entryWorkingDir;
        
        private Gtk.Button buttonBrowseWorkingDir;
        
        private Gtk.Label label1;
        
        private Gtk.Label label2;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.Projects.Gui.ProjectOptions.CommonDebugPreferences
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Projects.Gui.ProjectOptions.CommonDebugPreferences";
            // Container child MonoDevelop.Projects.Gui.ProjectOptions.CommonDebugPreferences.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(0));
            this.frame1.LabelXalign = 0F;
            // Container child frame1.Gtk.Container+ContainerChild
            this.GtkAlignment = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment.Name = "GtkAlignment";
            this.GtkAlignment.LeftPadding = ((uint)(12));
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            this.table1 = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.entryURL = new Gtk.Entry();
            this.entryURL.CanFocus = true;
            this.entryURL.Name = "entryURL";
            this.entryURL.IsEditable = true;
            this.entryURL.InvisibleChar = '●';
            this.table1.Add(this.entryURL);
            Gtk.Table.TableChild w1 = ((Gtk.Table.TableChild)(this.table1[this.entryURL]));
            w1.TopAttach = ((uint)(2));
            w1.BottomAttach = ((uint)(3));
            w1.LeftAttach = ((uint)(1));
            w1.RightAttach = ((uint)(2));
            w1.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.entryCommand = new Gtk.Entry();
            this.entryCommand.CanFocus = true;
            this.entryCommand.Name = "entryCommand";
            this.entryCommand.IsEditable = true;
            this.entryCommand.InvisibleChar = '●';
            this.hbox1.Add(this.entryCommand);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.entryCommand]));
            w2.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonBrowseCommand = new Gtk.Button();
            this.buttonBrowseCommand.CanFocus = true;
            this.buttonBrowseCommand.Name = "buttonBrowseCommand";
            this.buttonBrowseCommand.UseUnderline = true;
            this.buttonBrowseCommand.Label = MonoDevelop.Core.GettextCatalog.GetString("Browse...");
            this.hbox1.Add(this.buttonBrowseCommand);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonBrowseCommand]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            this.table1.Add(this.hbox1);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.hbox1]));
            w4.TopAttach = ((uint)(1));
            w4.BottomAttach = ((uint)(2));
            w4.LeftAttach = ((uint)(1));
            w4.RightAttach = ((uint)(2));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.radiobuttonCommandLine = new Gtk.RadioButton(MonoDevelop.Core.GettextCatalog.GetString("_Command line:"));
            this.radiobuttonCommandLine.CanFocus = true;
            this.radiobuttonCommandLine.Name = "radiobuttonCommandLine";
            this.radiobuttonCommandLine.DrawIndicator = true;
            this.radiobuttonCommandLine.UseUnderline = true;
            this.radiobuttonCommandLine.Group = new GLib.SList(System.IntPtr.Zero);
            this.table1.Add(this.radiobuttonCommandLine);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.radiobuttonCommandLine]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.radiobuttonProject = new Gtk.RadioButton(MonoDevelop.Core.GettextCatalog.GetString("_Project:"));
            this.radiobuttonProject.CanFocus = true;
            this.radiobuttonProject.Name = "radiobuttonProject";
            this.radiobuttonProject.DrawIndicator = true;
            this.radiobuttonProject.UseUnderline = true;
            this.radiobuttonProject.Group = this.radiobuttonCommandLine.Group;
            this.table1.Add(this.radiobuttonProject);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.radiobuttonProject]));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.radiobuttonURL = new Gtk.RadioButton(MonoDevelop.Core.GettextCatalog.GetString("_URL:"));
            this.radiobuttonURL.CanFocus = true;
            this.radiobuttonURL.Name = "radiobuttonURL";
            this.radiobuttonURL.DrawIndicator = true;
            this.radiobuttonURL.UseUnderline = true;
            this.radiobuttonURL.Group = this.radiobuttonCommandLine.Group;
            this.table1.Add(this.radiobuttonURL);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.radiobuttonURL]));
            w7.TopAttach = ((uint)(2));
            w7.BottomAttach = ((uint)(3));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            this.GtkAlignment.Add(this.table1);
            this.frame1.Add(this.GtkAlignment);
            this.GtkLabel4 = new Gtk.Label();
            this.GtkLabel4.Name = "GtkLabel4";
            this.GtkLabel4.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("<b>Start Action:</b>");
            this.GtkLabel4.UseMarkup = true;
            this.frame1.LabelWidget = this.GtkLabel4;
            this.vbox1.Add(this.frame1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox1[this.frame1]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.table2 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table2.Name = "table2";
            this.table2.RowSpacing = ((uint)(6));
            this.table2.ColumnSpacing = ((uint)(6));
            // Container child table2.Gtk.Table+TableChild
            this.entryArguments = new Gtk.Entry();
            this.entryArguments.CanFocus = true;
            this.entryArguments.Name = "entryArguments";
            this.entryArguments.IsEditable = true;
            this.entryArguments.InvisibleChar = '●';
            this.table2.Add(this.entryArguments);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table2[this.entryArguments]));
            w11.LeftAttach = ((uint)(1));
            w11.RightAttach = ((uint)(2));
            w11.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.entryWorkingDir = new Gtk.Entry();
            this.entryWorkingDir.CanFocus = true;
            this.entryWorkingDir.Name = "entryWorkingDir";
            this.entryWorkingDir.IsEditable = true;
            this.entryWorkingDir.InvisibleChar = '●';
            this.hbox2.Add(this.entryWorkingDir);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.hbox2[this.entryWorkingDir]));
            w12.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.buttonBrowseWorkingDir = new Gtk.Button();
            this.buttonBrowseWorkingDir.CanFocus = true;
            this.buttonBrowseWorkingDir.Name = "buttonBrowseWorkingDir";
            this.buttonBrowseWorkingDir.UseUnderline = true;
            this.buttonBrowseWorkingDir.Label = MonoDevelop.Core.GettextCatalog.GetString("Browse...");
            this.hbox2.Add(this.buttonBrowseWorkingDir);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox2[this.buttonBrowseWorkingDir]));
            w13.Position = 1;
            w13.Expand = false;
            w13.Fill = false;
            this.table2.Add(this.hbox2);
            Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.table2[this.hbox2]));
            w14.TopAttach = ((uint)(1));
            w14.BottomAttach = ((uint)(2));
            w14.LeftAttach = ((uint)(1));
            w14.RightAttach = ((uint)(2));
            w14.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("Command Line Arguments:");
            this.table2.Add(this.label1);
            Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table2[this.label1]));
            w15.XOptions = ((Gtk.AttachOptions)(4));
            w15.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("Working Directory:");
            this.label2.Justify = ((Gtk.Justification)(1));
            this.table2.Add(this.label2);
            Gtk.Table.TableChild w16 = ((Gtk.Table.TableChild)(this.table2[this.label2]));
            w16.TopAttach = ((uint)(1));
            w16.BottomAttach = ((uint)(2));
            w16.XOptions = ((Gtk.AttachOptions)(4));
            w16.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox1.Add(this.table2);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox1[this.table2]));
            w17.Position = 1;
            w17.Expand = false;
            w17.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
