using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveHeroCooperation.Utils
{
    public static class FileHelper
    {
        public static String UploadDocument(String title)
        {
            string path = "";
            using var ofd = new OpenFileDialog
            {
                Title = "Choose File " + title,
                Filter = "Image/PDF|*.jpg;*.jpeg;*.png;*.pdf"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Simpan file ke folder aplikasi (atau folder server khusus)
                var targetFolder = Path.Combine(AppContext.BaseDirectory, "Uploads");
                Directory.CreateDirectory(targetFolder);

                var fileName = Path.GetFileName(ofd.FileName);
                var destPath = Path.Combine(targetFolder, fileName);
                File.Copy(ofd.FileName, destPath, true);

                path = destPath; // tampilkan path
            }
            return path;
        }

        public static void ShowFile(string path)
        {
            // Ambil path dari TextBox
            var filePath = path.Trim();

            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Path file kosong.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File tidak ditemukan:\n" + filePath, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Buka file dengan aplikasi default di Windows
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true   // Penting untuk Windows 10/11
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka file:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
