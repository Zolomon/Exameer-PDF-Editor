
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Button btnOpenFileDialog;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Label label3;
	private global::Gtk.Entry entry2;
	private global::Gtk.Button button190;
	private global::Gtk.Button btnConvert;
	private global::Gtk.Table table2;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.NodeView nodeViewPDF;
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	private global::Gtk.NodeView nodeViewPNG;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Button btnExtract;
	private global::Gtk.Label lblStatus;
	private global::Gtk.ProgressBar progressbar3;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Exameer P2P v0.0.1");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(6));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.btnOpenFileDialog = new global::Gtk.Button ();
		this.btnOpenFileDialog.CanFocus = true;
		this.btnOpenFileDialog.Name = "btnOpenFileDialog";
		this.btnOpenFileDialog.UseUnderline = true;
		this.btnOpenFileDialog.Label = global::Mono.Unix.Catalog.GetString ("Open PDFs ...");
		this.hbox3.Add (this.btnOpenFileDialog);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.btnOpenFileDialog]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Destination:");
		this.hbox4.Add (this.label3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label3]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.hbox4.Add (this.entry2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entry2]));
		w3.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.button190 = new global::Gtk.Button ();
		this.button190.CanFocus = true;
		this.button190.Name = "button190";
		this.button190.UseUnderline = true;
		this.button190.Label = global::Mono.Unix.Catalog.GetString ("Browse ...");
		this.hbox4.Add (this.button190);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.button190]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.hbox3.Add (this.hbox4);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.hbox4]));
		w5.Position = 1;
		// Container child hbox3.Gtk.Box+BoxChild
		this.btnConvert = new global::Gtk.Button ();
		this.btnConvert.CanFocus = true;
		this.btnConvert.Name = "btnConvert";
		this.btnConvert.UseUnderline = true;
		this.btnConvert.Label = global::Mono.Unix.Catalog.GetString ("Convert...");
		this.hbox3.Add (this.btnConvert);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.btnConvert]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.table2 = new global::Gtk.Table (((uint)(1)), ((uint)(4)), false);
		this.table2.Name = "table2";
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.nodeViewPDF = new global::Gtk.NodeView ();
		this.nodeViewPDF.CanFocus = true;
		this.nodeViewPDF.Name = "nodeViewPDF";
		this.GtkScrolledWindow.Add (this.nodeViewPDF);
		this.table2.Add (this.GtkScrolledWindow);
		// Container child table2.Gtk.Table+TableChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.nodeViewPNG = new global::Gtk.NodeView ();
		this.nodeViewPNG.CanFocus = true;
		this.nodeViewPNG.Name = "nodeViewPNG";
		this.GtkScrolledWindow1.Add (this.nodeViewPNG);
		this.table2.Add (this.GtkScrolledWindow1);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2 [this.GtkScrolledWindow1]));
		w11.LeftAttach = ((uint)(1));
		w11.RightAttach = ((uint)(2));
		this.vbox1.Add (this.table2);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table2]));
		w12.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btnExtract = new global::Gtk.Button ();
		this.btnExtract.CanFocus = true;
		this.btnExtract.Name = "btnExtract";
		this.btnExtract.UseUnderline = true;
		this.btnExtract.Label = global::Mono.Unix.Catalog.GetString ("Perform");
		this.hbox2.Add (this.btnExtract);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.btnExtract]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lblStatus = new global::Gtk.Label ();
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.LabelProp = "";
		this.hbox2.Add (this.lblStatus);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.lblStatus]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.progressbar3 = new global::Gtk.ProgressBar ();
		this.progressbar3.Name = "progressbar3";
		this.hbox2.Add (this.progressbar3);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.progressbar3]));
		w15.Position = 2;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w16.Position = 2;
		w16.Expand = false;
		w16.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 806;
		this.DefaultHeight = 721;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnOpenFileDialog.Clicked += new global::System.EventHandler (this.OnBtnOpenFileDialogClicked);
		this.btnConvert.Clicked += new global::System.EventHandler (this.OnBtnConvertClicked);
	}
}