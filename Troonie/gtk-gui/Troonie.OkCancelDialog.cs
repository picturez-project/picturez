
// This file has been generated by the GUI designer. Do not modify.
namespace Troonie
{
	public partial class OkCancelDialog
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.HBox hbox1;
		
		private global::Troonie.TroonieButton picBtnOk;
		
		private global::Troonie.TroonieButton picBtnCancel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Troonie.OkCancelDialog
			this.Name = "Troonie.OkCancelDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("PseudoTroonieContextMenu");
			this.WindowPosition = ((global::Gtk.WindowPosition)(2));
			// Container child Troonie.OkCancelDialog.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xpad = 20;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.label1.UseMarkup = true;
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			w1.Padding = ((uint)(3));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xpad = 20;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			this.vbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label2]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.picBtnOk = new global::Troonie.TroonieButton ();
			this.picBtnOk.Name = "picBtnOk";
			this.picBtnOk.CheckReleaseState = false;
			this.picBtnOk.BorderlineWidth = 2;
			this.picBtnOk.ButtonHeight = 30;
			this.picBtnOk.ButtonWidth = 0;
			this.picBtnOk.Font = "Arial";
			this.picBtnOk.Text = "OK";
			this.picBtnOk.TextSize = 10D;
			this.hbox1.Add (this.picBtnOk);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.picBtnOk]));
			w3.Position = 0;
			w3.Padding = ((uint)(4));
			// Container child hbox1.Gtk.Box+BoxChild
			this.picBtnCancel = new global::Troonie.TroonieButton ();
			this.picBtnCancel.Name = "picBtnCancel";
			this.picBtnCancel.CheckReleaseState = false;
			this.picBtnCancel.BorderlineWidth = 2;
			this.picBtnCancel.ButtonHeight = 30;
			this.picBtnCancel.ButtonWidth = 0;
			this.picBtnCancel.Font = "Arial";
			this.picBtnCancel.Text = "Cancel";
			this.picBtnCancel.TextSize = 10D;
			this.hbox1.Add (this.picBtnCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.picBtnCancel]));
			w4.Position = 2;
			w4.Padding = ((uint)(4));
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			w5.Padding = ((uint)(4));
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 325;
			this.DefaultHeight = 120;
			this.Show ();
			this.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnKeyPressEvent);
			this.picBtnOk.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnPicBtnOkButtonReleaseEvent);
			this.picBtnCancel.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnPicBtnCancelButtonReleaseEvent);
		}
	}
}
