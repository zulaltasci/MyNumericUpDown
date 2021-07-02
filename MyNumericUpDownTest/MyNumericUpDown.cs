using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class MyNumericUpDown : Control
    {
        /// <summary>
        /// private tipinde button ve textbox değişkenlerimi tanımlıyorum.
        /// </summary>
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        public int size = 200;
        
        /// <summary>
        /// MyNumericUpDown componentimin kurucu metodu.
        /// </summary>
        public MyNumericUpDown()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// value isminde bir property tanımlıyorum buradaki value kullanıcıdan numericupdown'ın artış azalış miktarını alan bir propertydir.
        /// </summary>
        private int value = 1;
        public int Value1
        {
            get => value;
            set
            {
                if (value > 0)
                {
                    this.value = value;
                }

            }
        }
        
        /// <summary>
        /// Kullanıcıdan maximim değeri alabilen bir property'dir. Varsayılan değeri 100 dür.
        /// </summary>
        private int maximum = 100;
        public int Maximum
        {
            get => maximum;
            set
            {
                maximum = value;
                Invalidate();
            }
        }
        
        /// <summary>
        /// Kullanıcıdan minimum değeri alabilen bir property'dir. Varsayılan değeri 0 dır.
        /// </summary>
        private int minimum = 0;
        public int Minimum
        {
            get => minimum;
            set
            {
                minimum = value;
                Invalidate();
            }
        }
        
        /// <summary>
        /// Textboxımızın varsayılan rengini tanımlayıp daha sonrasında kullanıcının seçerek değiştirmesi için bir property tanılandı.
        /// </summary>
        private Color textBoxBackColor = Color.Tomato;
        public Color TextBoxBackColor1
        {
            get => textBoxBackColor;
            set
            {
                textBoxBackColor = value;
                Invalidate();

            }
        }

        /// <summary>
        /// upButtonBackColorın varsayılan rengini tanımlayıp daha sonrasında kullanıcının seçerek değiştirmesi için bir property tanılandı.
        /// </summary>
        private Color upButtonBackColor = Color.Transparent;
        public Color UpButtonBackColor
        {
            get => upButtonBackColor;
            set
            {
                upButtonBackColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// upButtonBackColorın varsayılan rengini tanımlayıp daha sonrasında kullanıcının seçerek değiştirmesi için bir property tanılandı.
        /// </summary>
        private Color downButtonBackColor = Color.Transparent;
        public Color DownButtonBackColor
        {
            get => downButtonBackColor;
            set
            {
                downButtonBackColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// OnPaint metodumuzda property olarak tanımlanan arka plan renklerini kullanıcı seçtikten sonra bize göstermesi için tanımlamalar yapıldı.
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            this.textBox1.BackColor = TextBoxBackColor1;
            this.button1.BackColor = upButtonBackColor;
            this.button2.BackColor = downButtonBackColor;

            base.OnPaint(pe);
        }
        
        /// <summary>
        /// Controlümün içine gömülü olan button1,button2 ve textbox1 in özellikleri private olan InitializeComponent metodunda tanımlıdır.
        /// </summary>
        private void InitializeComponent()
        {
            this.Controls.Clear();

            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.Size = new Size(size, (int)(size * 0.3));
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(size * 0.15));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(size / 4 - 2, (int)(size * 0.3));
            this.button1.TabIndex = 0;
            this.button1.Text = "❮";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Click += Button1_Click;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(size * 0.15));
            this.button2.Location = new System.Drawing.Point(size * 3 / 4, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(size / 4 - 2, (int)(size * 0.3));
            this.button2.TabIndex = 0;
            this.button2.Text = "❯";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Click += Button2_Click;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(size * 0.16));
            this.textBox1.Location = new System.Drawing.Point(size / 4, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(size / 2 - 2, (int)(size * 0.3));
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += textBox1_KeyPress;
            // 
            // MyNumericUpDown
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        /// <summary>
        /// Sadece nümerik girişe izin veren metot.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        
        /// <summary>
        /// Button1 click olduğunda yani down butonuna basıldığında textboxı girilen malue değer kadar azaltıp bunu textboxa yazdıran metot.
        /// (Minumum değere kadar azaltabilir.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                textBox1.Text = "0";

            }
           else if (int.Parse(this.textBox1.Text) - Value1 >= Minimum)
            {
                this.textBox1.Text = (int.Parse(this.textBox1.Text) - Value1).ToString();
                
            }
        }
       
        /// <summary>
        /// Button2 click olduğunda yani upbutonuna basıldığında textboxı girilen value değer kadar artırıp bunu textboxa yazdıran metot.
        /// (Maximum değere kadar artırabilir.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text=="")
            {
                textBox1.Text = "0";

            }
            else if (int.Parse(this.textBox1.Text) + Value1 <= Maximum)
            {
                this.textBox1.Text = (int.Parse(this.textBox1.Text) + Value1).ToString();
               
            }
        }
        
        /// <summary>
        /// OnsizeChanged metodumuz controlü büyütüp küçülttüğümüzde buton font textbox ... bunların da aynı oranda büyüyüp küçülmesini sağlar.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            size = this.Size.Width;
            this.Height = (int)(size * 0.3);

            InitializeComponent();
        }
    }
}
