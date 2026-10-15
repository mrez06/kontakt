namespace WinFormsApp4
{
    partial class Form1
    {
        private Label lblUserName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblBirthDate;
        private PictureBox picProfile;
        private Button btnAddImage;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private MaskedTextBox txtBirthDate;
        private Button btnSave;
        private TextBox txtSavedInfo;
        private OpenFileDialog openImageDialog;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblUserName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblBirthDate = new Label();
            picProfile = new PictureBox();
            btnAddImage = new Button();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtBirthDate = new MaskedTextBox();
            btnSave = new Button();
            txtSavedInfo = new TextBox();
            openImageDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();

            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(304, 45);
            lblUserName.Text = "İstifadəçi adı";
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(304, 112);
            lblEmail.Text = "Gmail ünvanı";
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(304, 179);
            lblPhone.Text = "Telefon";
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(304, 246);
            lblBirthDate.Text = "Doğum tarixi";

            picProfile.BorderStyle = BorderStyle.FixedSingle;
            picProfile.Location = new Point(40, 30);
            picProfile.Size = new Size(194, 164);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabStop = false;

            btnAddImage.Location = new Point(40, 218);
            btnAddImage.Size = new Size(194, 42);
            btnAddImage.Text = "Şəkil əlavə et";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;

            txtUserName.Location = new Point(304, 64);
            txtUserName.Size = new Size(220, 23);
            txtUserName.PlaceholderText = "İstifadəçi adı";
            txtEmail.Location = new Point(304, 131);
            txtEmail.Size = new Size(220, 23);
            txtEmail.PlaceholderText = "Gmail ünvanı";
            txtPhone.Location = new Point(304, 198);
            txtPhone.Size = new Size(220, 23);
            txtPhone.PlaceholderText = "Telefon";
            txtBirthDate.Location = new Point(304, 265);
            txtBirthDate.Mask = "00/00/0000";
            txtBirthDate.Size = new Size(220, 23);
            txtBirthDate.ValidatingType = typeof(DateTime);

            btnSave.Location = new Point(304, 309);
            btnSave.Size = new Size(220, 42);
            btnSave.Text = "Yadda saxla";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            txtSavedInfo.Location = new Point(40, 383);
            txtSavedInfo.Multiline = true;
            txtSavedInfo.ReadOnly = true;
            txtSavedInfo.ScrollBars = ScrollBars.Vertical;
            txtSavedInfo.Size = new Size(484, 105);
            txtSavedInfo.BackColor = SystemColors.Window;

            openImageDialog.Filter = "Şəkil faylları|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tif;*.tiff|JPEG|*.jpg;*.jpeg|PNG|*.png|Bitmap|*.bmp|GIF|*.gif|TIFF|*.tif;*.tiff";
            openImageDialog.Title = "Profil şəklini seçin";
            openImageDialog.Multiselect = false;

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 530);
            Controls.Add(lblUserName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblBirthDate);
            Controls.Add(picProfile);
            Controls.Add(btnAddImage);
            Controls.Add(txtUserName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtBirthDate);
            Controls.Add(btnSave);
            Controls.Add(txtSavedInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
