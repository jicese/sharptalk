
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.HPaned hpaned1;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TreeView treeview1;
	private global::Gtk.Notebook notebook2;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("SharpTalk");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hpaned1 = new global::Gtk.HPaned ();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 210;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeview1 = new global::Gtk.TreeView ();
		this.treeview1.CanFocus = true;
		this.treeview1.Name = "treeview1";
		this.treeview1.HeadersVisible = false;
		this.GtkScrolledWindow.Add (this.treeview1);
		this.hpaned1.Add (this.GtkScrolledWindow);
		global::Gtk.Paned.PanedChild w2 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.GtkScrolledWindow]));
		w2.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.notebook2 = new global::Gtk.Notebook ();
		this.notebook2.CanFocus = true;
		this.notebook2.Name = "notebook2";
		this.notebook2.CurrentPage = -1;
		this.hpaned1.Add (this.notebook2);
		this.Add (this.hpaned1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 710;
		this.DefaultHeight = 383;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.treeview1.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.treeview1_ButtonPress);
		this.treeview1.RowActivated += new global::Gtk.RowActivatedHandler (this.treeview1_RowActivated);
	}
}