using BioGTK;
namespace PluginExample
{
    public class PluginExample : BioGTK.Plugin.IPlugin
    {
        public string Name => "PluginExample";
        public string MenuPath => "Tools/" + Name + ".dll";
        public bool ContextMenu => false;
        ImageView v;
        public void Execute()
        {
            //Since we will be using the GUI we call App.Initialize();
            BioImage bm = BioImage.OpenFile("F:\\TESTIMAGES\\CZI\\16Bit-ZStack.czi",0,false,false);
            v = ImageView.Create(bm);
            v.Show();
        }
    }
}
