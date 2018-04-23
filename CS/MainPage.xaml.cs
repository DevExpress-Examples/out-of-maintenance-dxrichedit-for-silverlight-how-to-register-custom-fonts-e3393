using System.Reflection;
using System.Windows.Controls;

namespace RichEditCustomFontsSL {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            
            DevExpress.Xpf.Drawing.FontManager.RegisterFontFamily("Monotype Corsiva",
                Assembly.GetExecutingAssembly().GetManifestResourceStream("RichEditCustomFontsSL.Fonts.mtcorsva.ttf"));
            richEditControl1.Document.DefaultCharacterProperties.FontName = "Monotype Corsiva";
            richEditControl1.ApplyTemplate();
        }
    }
}
