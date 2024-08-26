using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioRegistro.Events
{
    public class ChangeColor
    {
        public event EventHandler<Color> ColorChanged;

        public void ColorChange(Color color)
        {
            OnColorChange(color);
        }

        protected virtual void OnColorChange(Color color)
        {
            ColorChanged?.Invoke(this, color);
        }
    }
}
