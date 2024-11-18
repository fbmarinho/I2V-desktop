using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video.FFMPEG;

namespace I2V
{
    public partial class MainForm : Form
    {
        private string lastSelectedFolder = string.Empty;
        private Color backgroundColor = Color.White; // Cor padrão (preto)
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnBackgroundColor.BackColor = backgroundColor;
            lastSelectedFolder = Properties.Settings.Default.LastFolderPath;
            txbFolderPath.Text = lastSelectedFolder;
            cmbCompression.Items.AddRange(new string[] { "H.264" });
            cmbCompression.SelectedIndex = 0;

            cmbFramesPerSecond.Items.AddRange(new string[] { "30" });
            cmbFramesPerSecond.SelectedIndex = 0;


            fillFileList();

        }

        private void fillFileList() {

            var files = Directory.GetFiles(lastSelectedFolder, "*.png").OrderBy(f => f);
            var filenames = files.Select(Path.GetFileName).ToList();
            filesList.DataSource = filenames;
            status.Text = $"{filenames.Count} images found.";

            var firstImage = (Bitmap)Image.FromFile(files.ToList().First());

            txfOutputWidth.Text = firstImage.Width.ToString();
            txfOutputHeight.Text = firstImage.Height.ToString();

            txfOutputWidth.Enabled = false;
            txfOutputHeight.Enabled = false;

        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (!string.IsNullOrEmpty(lastSelectedFolder) && Directory.Exists(lastSelectedFolder))
                {
                    folderDialog.SelectedPath = lastSelectedFolder;
                }

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    lastSelectedFolder = folderDialog.SelectedPath;
                    txbFolderPath.Text = lastSelectedFolder;
                    txtLog.AppendText($"Selected folder: {lastSelectedFolder}{Environment.NewLine}");

                    // Salvar o último diretório nas configurações
                    Properties.Settings.Default.LastFolderPath = lastSelectedFolder;
                    Properties.Settings.Default.Save();

                    fillFileList();

                }

            }
        }

        private void btnGenerateVideo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastSelectedFolder) || !Directory.Exists(lastSelectedFolder))
            {
                MessageBox.Show("Please, select a valid folder with an image sequence.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string compression = cmbCompression.SelectedItem.ToString();
            string outputFile = Path.Combine(lastSelectedFolder, $"{txbOutput.Text}.mp4");
          
            GenerateVideo(lastSelectedFolder, compression, outputFile);
        }

        private void GenerateVideo(string folderPath, string compression, string outputFile)
        {
            var imageFiles = Directory.GetFiles(folderPath, "*.png")
                .OrderBy(f => f)
                .ToList();

            progressBar.Maximum = imageFiles.Count;
            progressBar.Value = 0;

            if (!imageFiles.Any())
            {
                MessageBox.Show("No PNG files founded in selected folder.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtLog.AppendText($"{imageFiles.Count} images {Environment.NewLine} found.");

            try
            {
                // Abrindo a primeira imagem para determinar as dimensões do vídeo
                using (var firstImage = (Bitmap)Image.FromFile(imageFiles.First()))
                {
                    int width = firstImage.Width;
                    int height = firstImage.Height;

                    // Criando o vídeo
                    using (var videoWriter = new VideoFileWriter())
                    {
                        // Escolhendo o codec
                        VideoCodec codec = compression == "Raw" ? VideoCodec.Raw : VideoCodec.H264;
                        int fps = Convert.ToInt16(cmbFramesPerSecond.SelectedItem.ToString());
                        // Abrindo o arquivo de vídeo
                        videoWriter.Open(outputFile, width, height, fps , codec);

                        foreach (var file in imageFiles)
                        {

                            using (var image = (Bitmap)Image.FromFile(file))
                            {
                                // Criar uma imagem com fundo
                                using (var frame = new Bitmap(width, height))
                                using (var graphics = Graphics.FromImage(frame))
                                {
                                    // Preencher o fundo com a cor selecionada
                                    graphics.Clear(backgroundColor);

                                    // Desenhar a imagem original sobre o fundo
                                    graphics.DrawImage(image, 0, 0, width, height);

                                    // Adicionar ao vídeo
                                    videoWriter.WriteVideoFrame(frame);
                                }
                            }
                            progressBar.Value++;
                            txtLog.AppendText($"Image added: {Path.GetFileName(file)}{Environment.NewLine}");
                            
                        }

                        videoWriter.Close();
                        
                    }
                }

                status.Text = "Video generated successfully !";
                txtLog.AppendText($"Video generated at {outputFile}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating video: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    backgroundColor = colorDialog.Color;
                    btnBackgroundColor.BackColor = backgroundColor;
                    txtLog.AppendText($"Background color selected: {backgroundColor}{Environment.NewLine}");
                }
            }
        }
    }
}
