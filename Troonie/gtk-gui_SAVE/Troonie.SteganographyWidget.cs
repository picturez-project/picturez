
// This file has been generated by the GUI designer. Do not modify.
namespace Troonie
{
	public partial class SteganographyWidget
	{
		private global::Gtk.VBox vboxA;
		
		private global::Gtk.EventBox eventboxToolbar;
		
		private global::Gtk.HBox hboxToolbarButtons;
		
		private global::Gtk.HBox hbox1;
		
		private global::Troonie.SimpleImagePanel simpleimagepanel1;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Frame frameSteganography;
		
		private global::Gtk.Alignment AlignmentFrameSteganography;
		
		private global::Gtk.VBox vboxSteganography;
		
		private global::Gtk.Frame frameModus;
		
		private global::Gtk.Alignment AlignmentFrameModus;
		
		private global::Gtk.HBox hboxModus;
		
		private global::Gtk.RadioButton rdBtnRead;
		
		private global::Gtk.RadioButton rdBtnWrite;
		
		private global::Gtk.Label lbFrameModus;
		
		private global::Gtk.Frame frameKey;
		
		private global::Gtk.Alignment AlignmentFrameKey;
		
		private global::Gtk.Entry entryKey;
		
		private global::Gtk.Label lbFrameKey;
		
		private global::Gtk.Frame frameContent;
		
		private global::Gtk.Alignment AlignmentFrameContent;
		
		private global::Gtk.ScrolledWindow scrolledwindowContent;
		
		private global::Gtk.TextView textviewContent;
		
		private global::Gtk.Label lbFrameContent;
		
		private global::Gtk.Label lbFrameSteganography;
		
		private global::Gtk.Frame frameCursorPos;
		
		private global::Gtk.Alignment GtkAlignment1;
		
		private global::Gtk.Label lbCursorPos;
		
		private global::Gtk.Label lbFrameCursorPos;
		
		private global::Troonie.TroonieButton btnOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Troonie.SteganographyWidget
			this.Name = "Troonie.SteganographyWidget";
			this.Title = global::Mono.Unix.Catalog.GetString ("SteganographyWidget");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Troonie.SteganographyWidget.Gtk.Container+ContainerChild
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
			this.simpleimagepanel1 = new global::Troonie.SimpleImagePanel ();
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
			this.frameSteganography = new global::Gtk.Frame ();
			this.frameSteganography.Name = "frameSteganography";
			// Container child frameSteganography.Gtk.Container+ContainerChild
			this.AlignmentFrameSteganography = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.AlignmentFrameSteganography.Name = "AlignmentFrameSteganography";
			this.AlignmentFrameSteganography.LeftPadding = ((uint)(12));
			this.AlignmentFrameSteganography.RightPadding = ((uint)(12));
			this.AlignmentFrameSteganography.BottomPadding = ((uint)(12));
			// Container child AlignmentFrameSteganography.Gtk.Container+ContainerChild
			this.vboxSteganography = new global::Gtk.VBox ();
			this.vboxSteganography.Name = "vboxSteganography";
			this.vboxSteganography.Spacing = 6;
			// Container child vboxSteganography.Gtk.Box+BoxChild
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
			this.rdBtnRead = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Read"));
			this.rdBtnRead.CanFocus = true;
			this.rdBtnRead.Name = "rdBtnRead";
			this.rdBtnRead.DrawIndicator = true;
			this.rdBtnRead.UseUnderline = true;
			this.rdBtnRead.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.hboxModus.Add (this.rdBtnRead);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxModus [this.rdBtnRead]));
			w4.Position = 0;
			// Container child hboxModus.Gtk.Box+BoxChild
			this.rdBtnWrite = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Write"));
			this.rdBtnWrite.CanFocus = true;
			this.rdBtnWrite.Name = "rdBtnWrite";
			this.rdBtnWrite.DrawIndicator = true;
			this.rdBtnWrite.UseUnderline = true;
			this.rdBtnWrite.Group = this.rdBtnRead.Group;
			this.hboxModus.Add (this.rdBtnWrite);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxModus [this.rdBtnWrite]));
			w5.Position = 1;
			this.AlignmentFrameModus.Add (this.hboxModus);
			this.frameModus.Add (this.AlignmentFrameModus);
			this.lbFrameModus = new global::Gtk.Label ();
			this.lbFrameModus.Name = "lbFrameModus";
			this.lbFrameModus.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Modus</b>");
			this.lbFrameModus.UseMarkup = true;
			this.frameModus.LabelWidget = this.lbFrameModus;
			this.vboxSteganography.Add (this.frameModus);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vboxSteganography [this.frameModus]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vboxSteganography.Gtk.Box+BoxChild
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
			this.vboxSteganography.Add (this.frameKey);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxSteganography [this.frameKey]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vboxSteganography.Gtk.Box+BoxChild
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
			this.vboxSteganography.Add (this.frameContent);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vboxSteganography [this.frameContent]));
			w15.Position = 2;
			this.AlignmentFrameSteganography.Add (this.vboxSteganography);
			this.frameSteganography.Add (this.AlignmentFrameSteganography);
			this.lbFrameSteganography = new global::Gtk.Label ();
			this.lbFrameSteganography.Name = "lbFrameSteganography";
			this.lbFrameSteganography.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Steganography</b>");
			this.lbFrameSteganography.UseMarkup = true;
			this.frameSteganography.LabelWidget = this.lbFrameSteganography;
			this.vbox1.Add (this.frameSteganography);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frameSteganography]));
			w18.Position = 0;
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
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frameCursorPos]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.btnOk = new global::Troonie.TroonieButton ();
			this.btnOk.Name = "btnOk";
			this.btnOk.CheckReleaseState = false;
			this.btnOk.BorderlineWidth = 3;
			this.btnOk.ButtonHeight = 35;
			this.btnOk.ButtonWidth = 0;
			this.btnOk.Font = "Arial";
			this.btnOk.Text = "OK";
			this.btnOk.TextSize = 14;
			this.vbox1.Add (this.btnOk);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.btnOk]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			this.hbox1.Add (this.vbox1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox1]));
			w23.Position = 1;
			w23.Padding = ((uint)(5));
			this.vboxA.Add (this.hbox1);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vboxA [this.hbox1]));
			w24.Position = 1;
			this.Add (this.vboxA);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 524;
			this.DefaultHeight = 361;
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
