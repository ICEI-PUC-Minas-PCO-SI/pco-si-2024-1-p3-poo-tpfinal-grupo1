using app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Views
{
    public partial class LeituristaMain : Form
    {
        public LeituristaModel ltrLogado { get; set; }
        public LeituristaMain()
        {
            InitializeComponent();
        }
    }
}
