namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private string? selectedImagePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object? sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                using var imageStream = new FileStream(openImageDialog.FileName, FileMode.Open, FileAccess.Read);
                using var selectedImage = Image.FromStream(imageStream);
                var imageCopy = new Bitmap(selectedImage);
                var oldImage = picProfile.Image;
                picProfile.Image = imageCopy;
                oldImage?.Dispose();
                selectedImagePath = openImageDialog.FileName;
            }
            catch (Exception ex) when (ex is ArgumentException or IOException)
            {
                MessageBox.Show(this, "Şəkil faylı oxuna bilmədi.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            var imageName = string.IsNullOrWhiteSpace(selectedImagePath)
                ? "Seçilməyib"
                : Path.GetFileName(selectedImagePath);

            txtSavedInfo.Text = $"İstifadəçi adı: {GetValue(txtUserName)}{Environment.NewLine}" +
                                 $"Gmail ünvanı: {GetValue(txtEmail)}{Environment.NewLine}" +
                                 $"Telefon: {GetValue(txtPhone)}{Environment.NewLine}" +
                                 $"Doğum tarixi: {GetValue(txtBirthDate)}{Environment.NewLine}" +
                                 $"Profil şəkli: {imageName}";
        }

        private static string GetValue(Control control)
        {
            return string.IsNullOrWhiteSpace(control.Text) ? "Daxil edilməyib" : control.Text.Trim();
        }
    }
}
