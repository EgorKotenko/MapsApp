namespace Maps
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browser = new System.Windows.Forms.WebBrowser();
            this.placeSearchButton = new System.Windows.Forms.Button();
            this.routeButton = new System.Windows.Forms.Button();
            this.strFrom = new System.Windows.Forms.TextBox();
            this.strTo = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.strPlace = new System.Windows.Forms.TextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.errorLabel3 = new System.Windows.Forms.Label();
            this.errorOKbutton = new System.Windows.Forms.Button();
            this.errorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.browser, "browser");
            this.browser.Name = "browser";
            this.browser.ScrollBarsEnabled = false;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // placeSearchButton
            // 
            this.placeSearchButton.BackColor = System.Drawing.Color.MintCream;
            resources.ApplyResources(this.placeSearchButton, "placeSearchButton");
            this.placeSearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.placeSearchButton.Name = "placeSearchButton";
            this.placeSearchButton.UseVisualStyleBackColor = false;
            this.placeSearchButton.Click += new System.EventHandler(this.placeSearchButton_Click);
            // 
            // routeButton
            // 
            this.routeButton.BackColor = System.Drawing.Color.MintCream;
            resources.ApplyResources(this.routeButton, "routeButton");
            this.routeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.routeButton.Name = "routeButton";
            this.routeButton.UseVisualStyleBackColor = false;
            this.routeButton.Click += new System.EventHandler(this.routeButton_Click);
            // 
            // strFrom
            // 
            resources.ApplyResources(this.strFrom, "strFrom");
            this.strFrom.BackColor = System.Drawing.Color.MintCream;
            this.strFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.strFrom.Name = "strFrom";
            // 
            // strTo
            // 
            resources.ApplyResources(this.strTo, "strTo");
            this.strTo.BackColor = System.Drawing.Color.MintCream;
            this.strTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.strTo.Name = "strTo";
            // 
            // labelFrom
            // 
            resources.ApplyResources(this.labelFrom, "labelFrom");
            this.labelFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFrom.Name = "labelFrom";
            // 
            // labelTo
            // 
            resources.ApplyResources(this.labelTo, "labelTo");
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTo.Name = "labelTo";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.MintCream;
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // strPlace
            // 
            this.strPlace.BackColor = System.Drawing.Color.MintCream;
            resources.ApplyResources(this.strPlace, "strPlace");
            this.strPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.strPlace.Name = "strPlace";
            this.strPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strPlace_KeyPress);
            // 
            // labelPlace
            // 
            resources.ApplyResources(this.labelPlace, "labelPlace");
            this.labelPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPlace.Name = "labelPlace";
            // 
            // errorPanel
            // 
            this.errorPanel.BackColor = System.Drawing.Color.Lavender;
            this.errorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorPanel.Controls.Add(this.errorLabel2);
            this.errorPanel.Controls.Add(this.errorLabel1);
            this.errorPanel.Controls.Add(this.errorLabel3);
            this.errorPanel.Controls.Add(this.errorOKbutton);
            resources.ApplyResources(this.errorPanel, "errorPanel");
            this.errorPanel.Name = "errorPanel";
            // 
            // errorLabel2
            // 
            resources.ApplyResources(this.errorLabel2, "errorLabel2");
            this.errorLabel2.Name = "errorLabel2";
            // 
            // errorLabel1
            // 
            resources.ApplyResources(this.errorLabel1, "errorLabel1");
            this.errorLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel1.Name = "errorLabel1";
            // 
            // errorLabel3
            // 
            resources.ApplyResources(this.errorLabel3, "errorLabel3");
            this.errorLabel3.Name = "errorLabel3";
            // 
            // errorOKbutton
            // 
            this.errorOKbutton.BackColor = System.Drawing.Color.MintCream;
            this.errorOKbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.errorOKbutton, "errorOKbutton");
            this.errorOKbutton.Name = "errorOKbutton";
            this.errorOKbutton.UseVisualStyleBackColor = false;
            this.errorOKbutton.Click += new System.EventHandler(this.errorOKbutton_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.errorPanel);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.strPlace);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.strTo);
            this.Controls.Add(this.strFrom);
            this.Controls.Add(this.routeButton);
            this.Controls.Add(this.placeSearchButton);
            this.Controls.Add(this.browser);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button placeSearchButton;
        private System.Windows.Forms.Button routeButton;
        private System.Windows.Forms.TextBox strFrom;
        private System.Windows.Forms.TextBox strTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox strPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.Label errorLabel3;
        private System.Windows.Forms.Button errorOKbutton;
        private System.Windows.Forms.Label errorLabel2;
        private System.Windows.Forms.Label errorLabel1;

    }
}

