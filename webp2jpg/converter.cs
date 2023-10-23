using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Webp;

namespace webp2jpg
{
    internal class converter
    {
        //properties
        internal List<string>? path_ims { get; set; }
        internal ProgressBar ax { get; set; }

        //methods
        internal void convert()
        {
            if (path_ims == null)
            {
                return;
            }

            var name_dir     = Path.GetDirectoryName(path_ims[0]);
            var name_savedir = Path.Combine(name_dir, "output");
            Directory.CreateDirectory(name_savedir);
            var im_total = path_ims.Count;
            ax.Maximum = im_total;
            ax.Value = 0;
            Cursor.Current = Cursors.WaitCursor;

            foreach (var path_im in path_ims)
            {
                //load image
                var image = SixLabors.ImageSharp.Image.Load<Rgba32>(path_im);
                var name_in = Path.GetFileNameWithoutExtension(path_im);
                var ext = Path.GetExtension(path_im);

                if (ext == ".webp")
                {
                    if (image.Frames.Count == 1)
                    {
                        //get save name
                        var name_out = Path.Combine(name_savedir, name_in + ".jpg");

                        //convert
                        JpegEncoder enc = new JpegEncoder() { Quality = 100 };
                        image.Save(name_out, enc);
                    }
                    else
                    {
                        Directory.CreateDirectory(Path.Combine(name_savedir, name_in));

                        int frameCount = image.Frames.Count;
                        Debug.WriteLine(frameCount);

                        for (int frameIdx = 0; frameIdx < frameCount; frameIdx++)
                        {
                            try
                            {
                                using (var frame = image.Frames.ExportFrame(frameIdx))
                                {
                                    var path_save = Path.Combine(name_savedir, name_in, frameIdx.ToString("D4")) + ".jpg";
                                    frame.Save(path_save);

                                    //Debug.WriteLine(path_save + ":" + frameIdx);
                                }
                            }
                            catch (System.ArgumentOutOfRangeException ex)
                            {
                                ax.Value = im_total;
                                return;
                            }

                        }
                    }
                }
                else if (ext == ".jpg"|| ext == ".JPG")
                {
                    //get save name
                    var name_out = Path.Combine(name_savedir, name_in+".webp");

                    //convert
                    WebpEncoder enc = new WebpEncoder() { FileFormat=WebpFileFormatType.Lossless, Quality=80};
                    image.Save(name_out, enc);
                }

                ax.Value += 1;
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
