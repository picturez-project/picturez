
// This file has been generated by the GUI designer. Do not modify.
namespace Picturez
{
	public partial class StitchWidget
	{
		private global::Gtk.VBox vboxA;
		private global::Gtk.EventBox eventboxToolbar;
		private global::Gtk.HBox hboxToolbarButtons;
		private global::Gtk.HBox hbox1;
		private global::Picturez.SimpleImagePanel simpleimagepanel1;
		private global::Gtk.VBox vbox1;
		private global::Gtk.Frame frameStitch;
		private global::Gtk.Alignment AlignmentFrameStitch;
		private global::Gtk.VBox vboxStitch;
		private global::Gtk.Frame frameModus;
		private global::Gtk.Alignment AlignmentFrameModus;
		private global::Gtk.HBox hboxModus;
		private global::Gtk.RadioButton rdBtnLandscape;
		private global::Gtk.RadioButton rdBtnPortrait;
		private global::Gtk.Label lbFrameModus;
		private global::Gtk.Frame frameImagePositions;
		private global::Gtk.Alignment AlignmentImagePositions;
		private global::Gtk.Table table1;
		private global::Picturez.PicturezButton btn01BottomMinus;
		private global::Picturez.PicturezButton btn01BottomPlus;
		private global::Picturez.PicturezButton btn01LeftMinus;
		private global::Picturez.PicturezButton btn01LeftPlus;
		private global::Picturez.PicturezButton btn01RightMinus;
		private global::Picturez.PicturezButton btn01RightPlus;
		private global::Picturez.PicturezButton btn01TopMinus;
		private global::Picturez.PicturezButton btn01TopPlus;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Label lbFrameImagePositions;
		private global::Gtk.Frame frameImagePositions1;
		private global::Gtk.Alignment AlignmentImagePositions1;
		private global::Gtk.Label lbFrameImagePositions1;
		private global::Gtk.Frame frameKey;
		private global::Gtk.Alignment AlignmentFrameKey;
		private global::Gtk.Entry entryKey;
		private global::Gtk.Label lbFrameKey;
		private global::Gtk.Frame frameContent;
		private global::Gtk.Alignment AlignmentFrameContent;
		private global::Gtk.ScrolledWindow scrolledwindowContent;
		private global::Gtk.TextView textviewContent;
		private global::Gtk.Label lbFrameContent;
		private global::Gtk.Label lbFrameStitch;
		private global::Gtk.Frame frameCursorPos;
		private global::Gtk.Alignment GtkAlignment1;
		private global::Gtk.Label lbCursorPos;
		private global::Gtk.Label lbFrameCursorPos;
		private global::Picturez.PicturezButton btnOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Picturez.StitchWidget
			this.Name = "Picturez.StitchWidget";
			this.Title = global::Mono.Unix.Catalog.GetString ("StitchWidget");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Picturez.StitchWidget.Gtk.Container+ContainerChild
			this.vboxA = new global::Gtk.VBox ();
			this.vboxA.Name = "vboxA";
			this.vboxA.Spacing = 6;
			// Container child vboxA.Gtk.Box+BoxChild
			this.eventboxToolbar = new global::Gtk.EventBox ();
			this.eventboxToolbar.Name = "eventboxToolbar";
			// Container child eventboxToolbar.Gtk.Container+ContainerChild
			this.hboxToolbarButtons = new global::Gtk.HBox ();
			this.hboxToolbarButtons.Name = "hboxToolbarButtons";
			this.hboxToolbarButtons.Spacing = 6;
			this.eventboxToolbar.Add (this.hboxToolbarButtons);
			this.vboxA.Add (this.eventboxToolbar);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxA [this.eventboxToolbar]));
			w2.Position = 0;
			w2.Expand = false;
			// Container child vboxA.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.simpleimagepanel1 = new global::Picturez.SimpleImagePanel ();
			this.simpleimagepanel1.Events = ((global::Gdk.EventMask)(256));
			this.simpleimagepanel1.Name = "simpleimagepanel1";
			this.simpleimagepanel1.ScaleCursorX = 0F;
			this.simpleimagepanel1.ScaleCursorY = 0F;
			this.hbox1.Add (this.simpleimagepanel1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.simpleimagepanel1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frameStitch = new global::Gtk.Frame ();
			this.frameStitch.Name = "frameStitch";
			// Container child frameStitch.Gtk.Container+ContainerChild
			this.AlignmentFrameStitch = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.AlignmentFrameStitch.Name = "AlignmentFrameStitch";
			this.AlignmentFrameStitch.LeftPadding = ((uint)(12));
			this.AlignmentFrameStitch.RightPadding = ((uint)(12));
			this.AlignmentFrameStitch.BottomPadding = ((uint)(12));
			// Container child AlignmentFrameStitch.Gtk.Container+ContainerChild
			this.vboxStitch = new global::Gtk.VBox ();
			this.vboxStitch.Name = "vboxStitch";
			this.vboxStitch.Spacing = 6;
			// Container child vboxStitch.Gtk.Box+BoxChild
			this.frameModus = new global::Gtk.Frame ();
			this.frameModus.Name = "frameModus";
			// Container child frameModus.Gtk.Container+ContainerChild
			this.AlignmentFrameModus = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.AlignmentFrameModus.Name = "AlignmentFrameModus";
			this.AlignmentFrameModus.LeftPadding = ((uint)(12));
			// Container child AlignmentFrameModus.Gtk.Container+ContainerChild
			this.hboxModus = new global::Gtk.HBox ();
			this.hboxModus.Name = "hboxModus";
			this.hboxModus.Spacing = 6;
			// Container child hboxModus.Gtk.Box+BoxChild
			this.rdBtnLandscape = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Landscape"));
			this.rdBtnLandscape.CanFocus = true;
			this.rdBtnLandscape.Name = "rdBtnLandscape";
			this.rdBtnLandscape.DrawIndicator = true;
			this.rdBtnLandscape.UseUnderline = true;
			this.rdBtnLandscape.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.hboxModus.Add (this.rdBtnLandscape);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxModus [this.rdBtnLandscape]));
			w4.Position = 0;
			// Container child hboxModus.Gtk.Box+BoxChild
			this.rdBtnPortrait = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Portrait"));
			this.rdBtnPortrait.CanFocus = true;
			this.rdBtnPortrait.Name = "rdBtnPortrait";
			this.rdBtnPortrait.DrawIndicator = true;
			this.rdBtnPortrait.UseUnderline = true;
			this.rdBtnPortrait.Group = this.rdBtnLandscape.Group;
			this.hboxModus.Add (this.rdBtnPortrait);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxModus [this.rdBtnPortrait]));
			w5.Position = 1;
			this.AlignmentFrameModus.Add (this.hboxModus);
			this.frameModus.Add (this.AlignmentFrameModus);
			this.lbFrameModus = new global::Gtk.Label ();
			this.lbFrameModus.Name = "lbFrameModus";
			this.lbFrameModus.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Modus</b>");
			this.lbFrameModus.UseMarkup = true;
			this.frameModus.LabelWidget = this.lbFrameModus;
			this.vboxStitch.Add (this.frameModus);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vboxStitch [this.frameModus]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vboxStitch.Gtk.Box+BoxChild
			this.frameImagePositions = new global::Gtk.Frame ();
			this.frameImagePositions.Name = "frameImagePositions";
			this.frameImagePositions.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frameImagePositions.Gtk.Container+ContainerChild
			this.AlignmentImagePositions = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.AlignmentImagePositions.Name = "AlignmentImagePositions";
			this.AlignmentImagePositions.LeftPadding = ((uint)(12));
			// Container child AlignmentImagePositions.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(10)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.btn01BottomMinus = new global::Picturez.PicturezButton ();
			this.btn01BottomMinus.Name = "btn01BottomMinus";
			this.btn01BottomMinus.CheckReleaseState = false;
			this.btn01BottomMinus.BorderlineWidth = 3;
			this.btn01BottomMinus.ButtonHeight = 25;
			this.btn01BottomMinus.Font = "Arial";
			this.btn01BottomMinus.Text = "-";
			this.btn01BottomMinus.TextSize = 14;
			this.table1.Add (this.btn01BottomMinus);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn01BottomMinus]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(3));
			w9.RightAttach = ((uint)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btn01BottomPlus = new global::Picturez.PicturezButton ();
			this.btn01BottomPlus.Name = "btn01BottomPlus";
			this.btn01BottomPlus.CheckReleaseState = false;
			this.btn01BottomPlus.BorderlineWidth = 3;
			this.btn01BottomPlus.ButtonHeight = 25;
			this.btn01BottomPlus.Font = "Arial";
			this.btn01BottomPlus.Text = "+";
			this.btn01BottomPlus.TextSize = 14;
			this.table1.Add (this.btn01BottomPlus);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn01BottomPlus]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btn01LeftMinus = new global::Picturez.PicturezButton ();
			this.btn01LeftMinus.Name = "btn01LeftMinus";
			this.btn01LeftMinus.CheckReleaseState = false;
			this.btn01LeftMinus.BorderlineWidth = 3;
			this.btn01LeftMinus.ButtonHeight = 25;
			this.btn01LeftMinus.Font = "Arial";
			this.btn01LeftMinus.Text = "-";
			this.btn01LeftMinus.TextSize = 14;
			this.table1.Add (this.btn01LeftMinus);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn01LeftMinus]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btn01LeftPlus = new global::Picturez.PicturezButton ();
			this.btn01LeftPlus.Name = "btn01LeftPlus";
			this.btn01LeftPlus.CheckReleaseState = false;
			this.btn01LeftPlus.BorderlineWidth = 3;
			this.btn01LeftPlus.ButtonHeight = 25;
			this.btn01LeftPlus.Font = "Arial";
			this.btn01LeftPlus.Text = "+";
			this.btn01LeftPlus.TextSize = 14;
			this.table1.Add (this.btn01LeftPlus);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn01LeftPlus]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btn01RightMinus = new global::Picturez.PicturezButton ();
			this.btn01RightMinus.Name = "btn01RightMinus";
			this.btn01RightMinus.CheckReleaseState = false;
			this.btn01RightMinus.BorderlineWidth = 3;
			this.btn01RightMinus.ButtonHeight = 25;
			this.btn01RightMinus.Font = "Arial";
			this.btn01RightMinus.Text = "-";
			this.btn01RightMinus.TextSize = 14;
			this.table1.Add (this.btn01RightMinus);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn01RightMinus]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(5));
			w13.RightAttach = ((uint)(6));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btn01RightPlus = new global::Picturez.PicturezButton ();
			this.btn01RightPlus.Name = "btn01RightPlus";
			this.btn01RightPlus.CheckReleaseState = false;
			this.btn01RightPlus.BorderlineWidth = 3;
			this.btn01RightPlus.ButtonHeight = 25;
			this.btn01RightPlus.Font = "Arial";
			this.btn01RightPlus.Text = "+";
			this.btn01RightPlus.TextSize = 14;
			this.table1.Add (this.btn01RightPlus);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn01RightPlus]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.LeftAttach = ((uint)(4));
			w14.RightAttach = ((uint)(5));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btn01TopMinus = new global::Picturez.PicturezButton ();
			this.btn01TopMinus.Name = "btn01TopMinus";
			this.btn01TopMinus.CheckReleaseState = false;
			this.btn01TopMinus.BorderlineWidth = 3;
			this.btn01TopMinus.ButtonHeight = 25;
			this.btn01TopMinus.Font = "Arial";
			this.btn01TopMinus.Text = "-";
			this.btn01TopMinus.TextSize = 14;
			this.table1.Add (this.btn01TopMinus);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn01TopMinus]));
			w15.LeftAttach = ((uint)(3));
			w15.RightAttach = ((uint)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btn01TopPlus = new global::Picturez.PicturezButton ();
			this.btn01TopPlus.Name = "btn01TopPlus";
			this.btn01TopPlus.CheckReleaseState = false;
			this.btn01TopPlus.BorderlineWidth = 3;
			this.btn01TopPlus.ButtonHeight = 25;
			this.btn01TopPlus.Font = "Arial";
			this.btn01TopPlus.Text = "+";
			this.btn01TopPlus.TextSize = 14;
			this.table1.Add (this.btn01TopPlus);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.btn01TopPlus]));
			w16.LeftAttach = ((uint)(2));
			w16.RightAttach = ((uint)(3));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.LeftAttach = ((uint)(7));
			w17.RightAttach = ((uint)(8));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w18.LeftAttach = ((uint)(8));
			w18.RightAttach = ((uint)(9));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.LeftAttach = ((uint)(9));
			w19.RightAttach = ((uint)(10));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.LeftAttach = ((uint)(8));
			w20.RightAttach = ((uint)(9));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			this.AlignmentImagePositions.Add (this.table1);
			this.frameImagePositions.Add (this.AlignmentImagePositions);
			this.lbFrameImagePositions = new global::Gtk.Label ();
			this.lbFrameImagePositions.Name = "lbFrameImagePositions";
			this.lbFrameImagePositions.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Image Positions</b>");
			this.lbFrameImagePositions.UseMarkup = true;
			this.frameImagePositions.LabelWidget = this.lbFrameImagePositions;
			this.vboxStitch.Add (this.frameImagePositions);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vboxStitch [this.frameImagePositions]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vboxStitch.Gtk.Box+BoxChild
			this.frameImagePositions1 = new global::Gtk.Frame ();
			this.frameImagePositions1.Name = "frameImagePositions1";
			this.frameImagePositions1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frameImagePositions1.Gtk.Container+ContainerChild
			this.AlignmentImagePositions1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.AlignmentImagePositions1.Name = "AlignmentImagePositions1";
			this.AlignmentImagePositions1.LeftPadding = ((uint)(12));
			this.frameImagePositions1.Add (this.AlignmentImagePositions1);
			this.lbFrameImagePositions1 = new global::Gtk.Label ();
			this.lbFrameImagePositions1.Name = "lbFrameImagePositions1";
			this.lbFrameImagePositions1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Image Positions</b>");
			this.lbFrameImagePositions1.UseMarkup = true;
			this.frameImagePositions1.LabelWidget = this.lbFrameImagePositions1;
			this.vboxStitch.Add (this.frameImagePositions1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vboxStitch [this.frameImagePositions1]));
			w25.Position = 2;
			// Container child vboxStitch.Gtk.Box+BoxChild
			this.frameKey = new global::Gtk.Frame ();
			this.frameKey.Name = "frameKey";
			// Container child frameKey.Gtk.Container+ContainerChild
			this.AlignmentFrameKey = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.AlignmentFrameKey.Name = "AlignmentFrameKey";
			this.AlignmentFrameKey.LeftPadding = ((uint)(12));
			// Container child AlignmentFrameKey.Gtk.Container+ContainerChild
			this.entryKey = new global::Gtk.Entry ();
			this.entryKey.CanFocus = true;
			this.entryKey.Name = "entryKey";
			this.entryKey.IsEditable = true;
			this.entryKey.MaxLength = 128;
			this.entryKey.Visibility = false;
			this.entryKey.InvisibleChar = '●';
			this.AlignmentFrameKey.Add (this.entryKey);
			this.frameKey.Add (this.AlignmentFrameKey);
			this.lbFrameKey = new global::Gtk.Label ();
			this.lbFrameKey.Name = "lbFrameKey";
			this.lbFrameKey.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Key</b>");
			this.lbFrameKey.UseMarkup = true;
			this.frameKey.LabelWidget = this.lbFrameKey;
			this.vboxStitch.Add (this.frameKey);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vboxStitch [this.frameKey]));
			w28.Position = 3;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vboxStitch.Gtk.Box+BoxChild
			this.frameContent = new global::Gtk.Frame ();
			this.frameContent.Name = "frameContent";
			// Container child frameContent.Gtk.Container+ContainerChild
			this.AlignmentFrameContent = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.AlignmentFrameContent.Name = "AlignmentFrameContent";
			this.AlignmentFrameContent.LeftPadding = ((uint)(12));
			// Container child AlignmentFrameContent.Gtk.Container+ContainerChild
			this.scrolledwindowContent = new global::Gtk.ScrolledWindow ();
			this.scrolledwindowContent.CanFocus = true;
			this.scrolledwindowContent.Name = "scrolledwindowContent";
			this.scrolledwindowContent.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindowContent.Gtk.Container+ContainerChild
			this.textviewContent = new global::Gtk.TextView ();
			this.textviewContent.Buffer.Text = "Testtext";
			this.textviewContent.CanFocus = true;
			this.textviewContent.Name = "textviewContent";
			this.scrolledwindowContent.Add (this.textviewContent);
			this.AlignmentFrameContent.Add (this.scrolledwindowContent);
			this.frameContent.Add (this.AlignmentFrameContent);
			this.lbFrameContent = new global::Gtk.Label ();
			this.lbFrameContent.Name = "lbFrameContent";
			this.lbFrameContent.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Content</b>");
			this.lbFrameContent.UseMarkup = true;
			this.frameContent.LabelWidget = this.lbFrameContent;
			this.vboxStitch.Add (this.frameContent);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vboxStitch [this.frameContent]));
			w32.Position = 4;
			this.AlignmentFrameStitch.Add (this.vboxStitch);
			this.frameStitch.Add (this.AlignmentFrameStitch);
			this.lbFrameStitch = new global::Gtk.Label ();
			this.lbFrameStitch.Name = "lbFrameStitch";
			this.lbFrameStitch.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Stitch</b>");
			this.lbFrameStitch.UseMarkup = true;
			this.frameStitch.LabelWidget = this.lbFrameStitch;
			this.vbox1.Add (this.frameStitch);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frameStitch]));
			w35.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frameCursorPos = new global::Gtk.Frame ();
			this.frameCursorPos.Name = "frameCursorPos";
			// Container child frameCursorPos.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.lbCursorPos = new global::Gtk.Label ();
			this.lbCursorPos.Name = "lbCursorPos";
			this.lbCursorPos.LabelProp = global::Mono.Unix.Catalog.GetString ("0 x 0");
			this.GtkAlignment1.Add (this.lbCursorPos);
			this.frameCursorPos.Add (this.GtkAlignment1);
			this.lbFrameCursorPos = new global::Gtk.Label ();
			this.lbFrameCursorPos.Name = "lbFrameCursorPos";
			this.lbFrameCursorPos.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Cursor position</b>");
			this.lbFrameCursorPos.UseMarkup = true;
			this.frameCursorPos.LabelWidget = this.lbFrameCursorPos;
			this.vbox1.Add (this.frameCursorPos);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frameCursorPos]));
			w38.Position = 1;
			w38.Expand = false;
			w38.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.btnOk = new global::Picturez.PicturezButton ();
			this.btnOk.Name = "btnOk";
			this.btnOk.CheckReleaseState = false;
			this.btnOk.BorderlineWidth = 3;
			this.btnOk.ButtonHeight = 35;
			this.btnOk.Font = "Arial";
			this.btnOk.Text = "OK";
			this.btnOk.TextSize = 14;
			this.vbox1.Add (this.btnOk);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.btnOk]));
			w39.Position = 2;
			w39.Expand = false;
			w39.Fill = false;
			this.hbox1.Add (this.vbox1);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox1]));
			w40.Position = 1;
			w40.Padding = ((uint)(5));
			this.vboxA.Add (this.hbox1);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vboxA [this.hbox1]));
			w41.Position = 1;
			this.Add (this.vboxA);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 524;
			this.DefaultHeight = 418;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.DragDrop += new global::Gtk.DragDropHandler (this.OnDragDrop);
			this.DragDataReceived += new global::Gtk.DragDataReceivedHandler (this.OnDragDataReceived);
			this.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnKeyPressEvent);
			this.entryKey.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnEntryKeyKeyReleaseEvent);
			this.btnOk.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnBtnOkButtonReleaseEvent);
		}
	}
}