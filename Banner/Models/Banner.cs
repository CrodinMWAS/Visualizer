using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banner.Models
{

    public class UjabbBanner : Banner
    {
        public UjabbBanner()
        {
            HelpFiller(Color.Red);
        }
    }
    public class Banner : ABanner, IBannerOperations
    {
        public void Clear()
        {

            HelpFiller(BackgroundColor);
        }

        public void DrawLine(int rowIndex, Color drawingColor)
        {
            throw new NotImplementedException();
        }

        public void Fill(Color fillColor)
        {
            HelpFiller(fillColor);
        }

        public void ReplaceColor(Color oldColor, Color newColor)
        {
            throw new NotImplementedException();
        }

        public void RotateToLeft()
        {
            throw new NotImplementedException();
        }

        public void RotateToRight()
        {
            throw new NotImplementedException();
        }

        public void ShiftToLeft(Color fillColor)
        {
            throw new NotImplementedException();
        }

        public void ShiftToRight(Color fillColor)
        {
            throw new NotImplementedException();
        }

        void IBannerOperations.DrawLine(int lineIndex, Color drawingColor, IBannerOperations.Orientation lineOrientation)
        {
            throw new NotImplementedException();
        }
    }
}
