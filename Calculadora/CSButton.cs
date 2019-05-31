using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;

namespace Calculadora
{
    public class CSButton : Button
    {
        public CSButton()
        {
            SetStyle(ControlStyles.Selectable, false);
            FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
            FlatAppearance.BorderSize = 1;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Century Gothic", 18);
        }

        //Definindo o Destructor
        ~CSButton()
        {

        }

        public override Color ForeColor
        {
            get
            {
                return Color.White;
            }
            set
            {
                base.ForeColor = value;
            }
        }

        public override Color BackColor
        {
            get
            {
                if (CSBackColorChange == "Laranja")
                {
                    return Color.FromArgb(248, 123, 15);
                }
                else if (CSBackColorChange == "Cinza Claro")
                {
                    return Color.FromArgb(204, 205, 209);
                }
                else if (CSBackColorChange == "Cinza Escuro")
                {
                    return Color.FromArgb(195, 196, 198);
                }
                else
                {
                    return Color.White;
                }
            }
            set
            {
                base.BackColor = value;
            }
        }

        public class CSBackColor : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return new StandardValuesCollection(new string[] { "Laranja", "Cinza Claro", "Cinza Escuro" });
            }
        }

        [TypeConverter(typeof(CSBackColor)), Category("color")]
        public string CSBackColorChange
        {
            get;
            set;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = System.Drawing.Color.LightYellow;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.White;
        }
    }
}
