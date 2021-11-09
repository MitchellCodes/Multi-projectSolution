namespace ChuckNorrisWinForm
{
    partial class ChuckNorrisForm
    {
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
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.btnGetRandomJoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(300, 96);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(121, 23);
            this.cbxCategories.TabIndex = 0;
            // 
            // btnGetRandomJoke
            // 
            this.btnGetRandomJoke.Location = new System.Drawing.Point(206, 284);
            this.btnGetRandomJoke.Name = "btnGetRandomJoke";
            this.btnGetRandomJoke.Size = new System.Drawing.Size(374, 73);
            this.btnGetRandomJoke.TabIndex = 1;
            this.btnGetRandomJoke.Text = "Get Random Joke";
            this.btnGetRandomJoke.UseVisualStyleBackColor = true;
            this.btnGetRandomJoke.Click += new System.EventHandler(this.btnGetRandomJoke_Click);
            // 
            // ChuckNorrisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetRandomJoke);
            this.Controls.Add(this.cbxCategories);
            this.Name = "ChuckNorrisForm";
            this.Text = "Chuck Norris Jokes";
            this.Load += new System.EventHandler(this.ChuckNorrisForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbxCategories;
        private Button btnGetRandomJoke;
    }
}