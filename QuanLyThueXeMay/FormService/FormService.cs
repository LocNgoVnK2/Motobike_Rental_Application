using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXeMay.FormService
{
    public static class FormService
    {
        // class dùng dể import các dll


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
    );
        public static byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                // lưu ảnh thành luồng 
                image.Save(stream, image.RawFormat);

                // chuyển luồng thành dạng array
                return stream.ToArray();
            }
        }

        public static System.Drawing.Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream stream = new MemoryStream(byteArray))
            {
                System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
                return image;
            }
        }

        public static System.Drawing.Image LoadImage(UserDTO loginAccount)
        {
            if (loginAccount.Image == null)
            {
                return global::QuanLyThueXeMay.Properties.Resources.AvatarXanhNho;
            }
            return ByteArrayToImage(loginAccount.Image.ToArray());
        }
        public static System.Drawing.Image LoadImageVehicle(VehicleDTO vehicle)
        {
            if (vehicle.VehiclePicture == null)
            {
                return global::QuanLyThueXeMay.Properties.Resources.MoToFlash;
            }
            return ByteArrayToImage(vehicle.VehiclePicture.ToArray());
        }
    }
}
