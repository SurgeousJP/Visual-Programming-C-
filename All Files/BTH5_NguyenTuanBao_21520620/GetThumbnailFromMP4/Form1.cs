using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.VideoConverter;
namespace GetThumbnailFromMP4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            string videofilePath = @"C:\Users\tuanb\Downloads\Video\Hatsune Miku Magical Mirai 2019- Boku ga Yume o Sutete Otona ni Naru made (Vietsub).mp4";
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            ffMpeg.GetVideoThumbnail(videofilePath, @"C:\Users\tuanb\Downloads\Video", 5);
        }
    }
}
