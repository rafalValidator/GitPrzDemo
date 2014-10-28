using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyArchive.Util
{
    class LabelDisplay : ITextDisplay
    {
        Label _label;

        public LabelDisplay(Label label)
        {
            _label = label;
        }

        public void Show(string message)
        {
            _label.Text = message;
        }
    }
}
