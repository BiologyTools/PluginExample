using AForge;
using BioGTK;
using Gtk;
namespace PluginExample
{
    public class PluginExample : BioGTK.Plugin.IPlugin
    {
        public string Name => "PluginExample";
        public string MenuPath => "Tools/" + Name + ".dll";
        public bool ContextMenu => false;
        ImageView v;
        public void Execute(string[] args)
        {
            //Since we will be using the GUI we call App.Initialize();
            BioImage bm = BioImage.OpenFile("F:\\TESTIMAGES\\CZI\\16Bit-ZStack.czi",0,false,false);
            v = ImageView.Create(bm);
            v.Show();
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
        public void Drawn(object o, DrawnArgs e)
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
    }
}
