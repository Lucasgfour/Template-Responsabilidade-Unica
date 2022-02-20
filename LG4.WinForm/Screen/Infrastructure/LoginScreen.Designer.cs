namespace LG4.WinForm.Screen.Infrastructure {
    partial class LoginScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txt_usuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.lab_usuario = new MaterialSkin.Controls.MaterialLabel();
            this.txt_senha = new MaterialSkin.Controls.MaterialTextBox2();
            this.lab_senha = new MaterialSkin.Controls.MaterialLabel();
            this.btn_entrar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.AnimateReadOnly = false;
            this.txt_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_usuario.Depth = 0;
            this.txt_usuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_usuario.HideSelection = true;
            this.txt_usuario.LeadingIcon = null;
            this.txt_usuario.LeaveOnEnterKey = true;
            this.txt_usuario.Location = new System.Drawing.Point(275, 155);
            this.txt_usuario.MaxLength = 32767;
            this.txt_usuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PasswordChar = '\0';
            this.txt_usuario.PrefixSuffixText = null;
            this.txt_usuario.ReadOnly = false;
            this.txt_usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_usuario.SelectedText = "";
            this.txt_usuario.SelectionLength = 0;
            this.txt_usuario.SelectionStart = 0;
            this.txt_usuario.ShortcutsEnabled = true;
            this.txt_usuario.Size = new System.Drawing.Size(250, 36);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.TabStop = false;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_usuario.TrailingIcon = null;
            this.txt_usuario.UseSystemPasswordChar = false;
            this.txt_usuario.UseTallSize = false;
            // 
            // lab_usuario
            // 
            this.lab_usuario.Depth = 0;
            this.lab_usuario.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_usuario.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lab_usuario.Location = new System.Drawing.Point(275, 126);
            this.lab_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_usuario.Name = "lab_usuario";
            this.lab_usuario.Size = new System.Drawing.Size(250, 28);
            this.lab_usuario.TabIndex = 1;
            this.lab_usuario.Text = "Usuário";
            this.lab_usuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_senha
            // 
            this.txt_senha.AnimateReadOnly = false;
            this.txt_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_senha.Depth = 0;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_senha.HideSelection = true;
            this.txt_senha.LeadingIcon = null;
            this.txt_senha.LeaveOnEnterKey = true;
            this.txt_senha.Location = new System.Drawing.Point(275, 223);
            this.txt_senha.MaxLength = 32767;
            this.txt_senha.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '●';
            this.txt_senha.PrefixSuffixText = null;
            this.txt_senha.ReadOnly = false;
            this.txt_senha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_senha.SelectedText = "";
            this.txt_senha.SelectionLength = 0;
            this.txt_senha.SelectionStart = 0;
            this.txt_senha.ShortcutsEnabled = true;
            this.txt_senha.Size = new System.Drawing.Size(250, 36);
            this.txt_senha.TabIndex = 2;
            this.txt_senha.TabStop = false;
            this.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_senha.TrailingIcon = null;
            this.txt_senha.UseSystemPasswordChar = true;
            this.txt_senha.UseTallSize = false;
            // 
            // lab_senha
            // 
            this.lab_senha.Depth = 0;
            this.lab_senha.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lab_senha.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lab_senha.Location = new System.Drawing.Point(275, 194);
            this.lab_senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lab_senha.Name = "lab_senha";
            this.lab_senha.Size = new System.Drawing.Size(250, 28);
            this.lab_senha.TabIndex = 3;
            this.lab_senha.Text = "Senha";
            this.lab_senha.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btn_entrar
            // 
            this.btn_entrar.AutoSize = false;
            this.btn_entrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_entrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_entrar.Depth = 0;
            this.btn_entrar.HighEmphasis = true;
            this.btn_entrar.Icon = null;
            this.btn_entrar.Location = new System.Drawing.Point(275, 289);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_entrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_entrar.Size = new System.Drawing.Size(250, 36);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_entrar.UseAccentColor = false;
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.CliqueLogar);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lab_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lab_usuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginScreen";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LG4 - Login";
            this.Load += new System.EventHandler(this.Loading);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txt_usuario;
        private MaterialSkin.Controls.MaterialLabel lab_usuario;
        private MaterialSkin.Controls.MaterialTextBox2 txt_senha;
        private MaterialSkin.Controls.MaterialLabel lab_senha;
        private MaterialSkin.Controls.MaterialButton btn_entrar;
    }
}