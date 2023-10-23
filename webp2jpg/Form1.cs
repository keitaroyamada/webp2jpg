using System.Diagnostics;
using System.Windows.Forms;

namespace webp2jpg
{
    public partial class Form1 : Form
    {
        internal converter conv;

        public Form1()
        {
            InitializeComponent();
            var conv = new converter();
            conv.direction = direction.Text;
            conv.path_ims = null;
        }

        private void import_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            var temp_image_paths = (string[])(e.Data.GetData(DataFormats.FileDrop, false));
            var image_paths = new List<string>();

            List<string> exts = new List<string> ();
            if (conv.direction == "webp => jpg")
            {
                exts.Add(".webp");
            }
            else if (conv.direction == "webp <= jpg")
            {
                exts.Add(".jpg");
                exts.Add(".JPG");
            }

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
                conv.path_ims = image_paths;
            }
            
        }

        private void import_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void direction_Click(object sender, EventArgs e)
        {
            if (direction.Text == "webp => jpg")
            {
                var txt = "webp <= jpg";
                conv.direction = txt;
                direction.Text = txt;
            }
            else if (direction.Text == "webp <= jpg")
            {
                var txt = "webp => jpg";
                conv.direction = txt;
                direction.Text = txt;
            }
        }
    }
}