using System.Diagnostics;
using System.Windows.Forms;
using SixLabors.ImageSharp;
using static System.Net.Mime.MediaTypeNames;

namespace webp2jpg
{
    public partial class Form1 : Form
    {
        internal converter conv;
        internal int direction_id;
        internal List<string> direction_list;

        public Form1()
        {
            InitializeComponent();
            conv = new converter();
            conv.path_ims = new List<string>();
            conv.ax = progressBar2;

            direction_id = 0;
            direction_list = new List<string>();
            direction_list.Add("webp => jpg");
            direction_list.Add("jpg => webp");
        }

        private void import_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            var temp_image_paths = (string[])(e.Data.GetData(DataFormats.FileDrop, false));
            var image_paths = new List<string>();

            List<string> exts = new List<string>();
            exts.Add(".webp");
            exts.Add(".jpg");
            exts.Add(".JPG");

            foreach (var temp_image_path in temp_image_paths)
            {
                foreach (var ext in exts)
                {
                    if (Path.GetExtension(temp_image_path) == ext)
                    {
                        image_paths.Add(temp_image_path);
                        Debug.WriteLine("Load image:" + temp_image_path);
                    }
                }
            }

            if (image_paths.Count != 0)
            {
                conv.path_ims.Clear();
                conv.path_ims = image_paths;
            }

            conv.convert();
        }

        private void import_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }


    }
}