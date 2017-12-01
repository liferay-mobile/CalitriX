using Calitrix.Forms.Enums;

namespace Calitrix.Forms.Util
{
    public class FontTypeUtil
    {
        public static string GetFont(FontType fontType)
        {
            var fontName = _getFontName(fontType);

            return _getFontPlataform(fontName);
        }

        private static string _getFontName(FontType fontType)
        {
            switch (fontType)
            {
                case FontType.Regular:
                    return "SourceSansPro-Regular";
                case FontType.Semibold:
                    return "SourceSansPro-Semibold";
                case FontType.Bold:
                    return "SourceSansPro-Bold";
                default:
                    return "SourceSansPro-Regular";
            }
        }

        private static string _getFontPlataform(string fontName) 
        {
            return fontName;
        }
    }
}
