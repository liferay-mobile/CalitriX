using Calitrix.Forms.Enums;
using Calitrix.Forms.Util;
using Xamarin.Forms;

namespace Calitrix.Forms 
{
    public class CustomLabel : Label 
    {
        static CustomLabel _customLabel;
        public static void Init() {
            _customLabel = new CustomLabel();
        }

        public FontType FontType {
            get; set;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            FontFamily = getFontFamily(FontType);
        }

        public virtual string getFontFamily(dynamic fontType) {
            return FontTypeUtil.GetFont(fontType);
        }


        public float LineHeight
        {
            get; set;
        }
    }
}
