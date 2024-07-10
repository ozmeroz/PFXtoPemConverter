using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFXtoPemConverter
{
    public partial class Pfx_Converter : Form
    {
        public Pfx_Converter()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            string pfxFilePath = txtPfxPath.Text;
            string pfxPassword = txtPassword.Text;
            string outputDirectory = "output";  // You can also add a browse option for the output directory

            try
            {
                ConvertPfxToPem(pfxFilePath, pfxPassword, outputDirectory);
                MessageBox.Show("Conversion completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PFX files (*.pfx)|*.pfx|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPfxPath.Text = openFileDialog.FileName;
            }
        }

        static void ConvertPfxToPem(string pfxFile, string pfxPassword, string outputDir)
        {
            // Ensure the output directory exists
            Directory.CreateDirectory(outputDir);

            // Paths for the output files
            string rootCaPem = Path.Combine(outputDir, "RootCA.pem");
            string certPem = Path.Combine(outputDir, "Certificate.pem");
            string keyPem = Path.Combine(outputDir, "Certificate.key.pem");

            // Paths to OpenSSL executable and arguments
            string opensslPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "openssl", "openssl.exe");

            // Extract the private key
            RunOpenSslCommand(opensslPath, $"pkcs12 -in \"{pfxFile}\" -nocerts -out \"{keyPem}\" -nodes -password pass:{pfxPassword}");

            // Extract the certificate
            RunOpenSslCommand(opensslPath, $"pkcs12 -in \"{pfxFile}\" -clcerts -nokeys -out \"{certPem}\" -password pass:{pfxPassword}");

            // Extract the CA certificates
            RunOpenSslCommand(opensslPath, $"pkcs12 -in \"{pfxFile}\" -cacerts -nokeys -out \"{rootCaPem}\" -password pass:{pfxPassword} -chain");
        }

        static void RunOpenSslCommand(string opensslPath, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = opensslPath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
                process.ErrorDataReceived += (sender, e) => Console.WriteLine(e.Data);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    throw new Exception($"OpenSSL command failed with exit code {process.ExitCode}");
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
