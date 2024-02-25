using AForge;
using BioGTK;
using Gdk;
using Gtk;
using SkiaSharp.Views.Desktop;
namespace PluginExample
{
    public class PluginExample : BioGTK.Plugin.IPlugin
    {
        public string Name => "PluginExample";
        public string MenuPath => "Tools/" + Name + ".dll";
        public bool ContextMenu => false;
        private MainWindow main;
        public void Execute(string[] args)
        {
            main = MainWindow.Create();
            main.Show();
        }
        public void KeyUpEvent(object o, KeyPressEventArgs e)
        {
            
        }
        public void KeyDownEvent(object o, KeyPressEventArgs e)
        {

        }
        public void ScrollEvent(object o, ScrollEventArgs args)
        {

        }
        public void Render(object sender, SKPaintSurfaceEventArgs e)
        {

        }
        public void MouseMove(object o, PointD e, MotionNotifyEventArgs buts)
        {

        }
        public void MouseUp(object o, PointD e, ButtonReleaseEventArgs buts)
        {

        }
        public void MouseDown(object o, PointD e, ButtonPressEventArgs buts)
        {

        }
        
        public class MainWindow : Gtk.Window
        {
            #region Properties
            Pixbuf pixbuf;
            private Builder _builder;
#pragma warning disable 649
            [Builder.Object]
            private Gtk.TextView textBox;
            [Builder.Object]
            private Gtk.Label mainLabel;
#pragma warning restore 649
            #endregion

            #region Constructors / Destructors

            /// It creates a new instance of the About class.
            /// 
            /// @return A new instance of the About class.
            public static MainWindow Create()
            {
                Builder builder = new Builder(null, "PluginExample.MainWindow.glade", null);
                return new MainWindow(builder, builder.GetObject("mainWindow").Handle);
            }


            /* It's the constructor of the class. */
            protected MainWindow(Builder builder, IntPtr handle) : base(handle)
            {
                _builder = builder;
                builder.Autoconnect(this);
                App.ApplyStyles(this);
                this.KeyPressEvent += MainWindow_KeyPressEvent;
                this.KeyReleaseEvent += MainWindow_KeyReleaseEvent;
                this.MotionNotifyEvent += MainWindow_MotionNotifyEvent;
                this.ButtonPressEvent += MainWindow_ButtonPressEvent;
                this.ButtonReleaseEvent += MainWindow_ButtonReleaseEvent;
                this.Drawn += MainWindow_Drawn;
            }

            private void MainWindow_Drawn(object o, DrawnArgs args)
            {
                args.Cr.LineWidth = 1;
                args.Cr.SetFontSize(12);
                args.Cr.SelectFontFace("Times New Roman", Cairo.FontSlant.Normal, Cairo.FontWeight.Normal);
                args.Cr.ShowText("MainWindow Drawn Event");
                args.Cr.Stroke();
            }

            private void MainWindow_ButtonReleaseEvent(object o, ButtonReleaseEventArgs args)
            {
                textBox.Buffer.Text += "ButtonReleaseEvent:" + args.Event.X + "," + args.Event.Y + "\n";
            }

            private void MainWindow_ButtonPressEvent(object o, ButtonPressEventArgs args)
            {
                textBox.Buffer.Text += "ButtonPressEvent:" + args.Event.X + "," + args.Event.Y + "\n";
            }

            private void MainWindow_MotionNotifyEvent(object o, MotionNotifyEventArgs args)
            {
                textBox.Buffer.Text += "MotionNotifyEvent:" + args.Event.X + "," + args.Event.Y + "\n";
            }

            private void MainWindow_KeyReleaseEvent(object o, KeyReleaseEventArgs args)
            {
                textBox.Buffer.Text += "KeyReleaseEvent:" + args.Event.Key.ToString() + "\n";
            }

            private void MainWindow_KeyPressEvent(object o, KeyPressEventArgs args)
            {
                textBox.Buffer.Text += "KeyPressEvent:" + args.Event.Key.ToString()  + "\n";
            }
            #endregion

        }
    }
}
