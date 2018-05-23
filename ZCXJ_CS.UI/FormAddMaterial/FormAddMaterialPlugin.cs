using System.ComponentModel.Composition;
using System.Drawing;
using System.Reflection;

namespace ZCXJ_CS.UI
{
    [Export(typeof(IUIPlugin))]
    public class FormAddMaterialPlugin : IUIPlugin
    {
        private FormBase _pluginForm = null;
        private Image _pluginPic = null;
        private Image _selectPluginPic = null;
        public FormBase PluginForm
        {
            get
            {
                if (_pluginForm == null)
                    _pluginForm = new FormAddMaterial();
                return _pluginForm;
            }
        }

        public virtual string PluginId
        {
            get
            {
                return this.GetType().FullName;
            }
        }

        public virtual string PluginPath
        {
            get
            {
                string SelfPath = Assembly.GetExecutingAssembly().Location;
                SelfPath = SelfPath.Substring(0, SelfPath.LastIndexOf('\\'));
                return SelfPath;
            }
        }

        public System.Drawing.Image PluginPic
        {
            get
            {
                if (_pluginPic == null)
                    _pluginPic = Image.FromFile(PluginPath + "\\Res\\上料防错.png");
                return _pluginPic;
            }
        }

        public string PluginText
        {
            get
            {
                return "彩盒通用料上料";
            }
        }

        public System.Drawing.Image SelectPluginPic
        {
            get
            {
                if (_selectPluginPic == null)
                    _selectPluginPic = Image.FromFile(PluginPath + "\\Res\\上料防错.png");
                return _selectPluginPic;
            }
        }
    }
}
