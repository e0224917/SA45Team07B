namespace SA45Team07B
{
    partial class AddNewPublisher
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
            this.components = new System.ComponentModel.Container();
            this.labelPublisherName = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelPublisherID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPublisherID = new System.Windows.Forms.TextBox();
            this.textBoxPublisherName = new System.Windows.Forms.TextBox();
            this.errorProviderPublisherID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPublisherName = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPublisherID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPublisherName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Visible = false;
            // 
            // labelPublisherName
            // 
            this.labelPublisherName.AutoSize = true;
            this.labelPublisherName.BackColor = System.Drawing.Color.Transparent;
            this.labelPublisherName.Location = new System.Drawing.Point(108, 275);
            this.labelPublisherName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPublisherName.Name = "labelPublisherName";
            this.labelPublisherName.Size = new System.Drawing.Size(279, 48);
            this.labelPublisherName.TabIndex = 31;
            this.labelPublisherName.Text = "Publisher Name:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.BackColor = System.Drawing.Color.Transparent;
            this.labelCountry.Location = new System.Drawing.Point(234, 350);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(153, 48);
            this.labelCountry.TabIndex = 27;
            this.labelCountry.Text = "Country:";
            // 
            // labelPublisherID
            // 
            this.labelPublisherID.AutoSize = true;
            this.labelPublisherID.BackColor = System.Drawing.Color.Transparent;
            this.labelPublisherID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPublisherID.Location = new System.Drawing.Point(168, 200);
            this.labelPublisherID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPublisherID.Name = "labelPublisherID";
            this.labelPublisherID.Size = new System.Drawing.Size(219, 48);
            this.labelPublisherID.TabIndex = 26;
            this.labelPublisherID.Text = "Publisher ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(380, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(380, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "*";
            // 
            // textBoxPublisherID
            // 
            this.textBoxPublisherID.Location = new System.Drawing.Point(424, 193);
            this.textBoxPublisherID.Name = "textBoxPublisherID";
            this.textBoxPublisherID.Size = new System.Drawing.Size(380, 55);
            this.textBoxPublisherID.TabIndex = 35;
            this.textBoxPublisherID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxPublisherID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxPublisherID.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPublisherID_Validating);
            this.textBoxPublisherID.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // textBoxPublisherName
            // 
            this.textBoxPublisherName.Location = new System.Drawing.Point(424, 268);
            this.textBoxPublisherName.Name = "textBoxPublisherName";
            this.textBoxPublisherName.Size = new System.Drawing.Size(500, 55);
            this.textBoxPublisherName.TabIndex = 36;
            this.textBoxPublisherName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxPublisherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxPublisherName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPublisherName_Validating);
            // 
            // errorProviderPublisherID
            // 
            this.errorProviderPublisherID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPublisherID.ContainerControl = this;
            // 
            // errorProviderPublisherName
            // 
            this.errorProviderPublisherName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPublisherName.ContainerControl = this;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.Location = new System.Drawing.Point(724, 428);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(262, 91);
            this.buttonCancel.TabIndex = 39;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(424, 428);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(262, 91);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.comboBoxCountry.Location = new System.Drawing.Point(424, 342);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(400, 56);
            this.comboBoxCountry.TabIndex = 37;
            // 
            // AddNewPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.ClientSize = new System.Drawing.Size(1472, 1121);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPublisherName);
            this.Controls.Add(this.textBoxPublisherID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPublisherName);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelPublisherID);
            this.Name = "AddNewPublisher";
            this.Text = "Add New Publisher";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.labelPublisherID, 0);
            this.Controls.SetChildIndex(this.labelCountry, 0);
            this.Controls.SetChildIndex(this.labelPublisherName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxPublisherID, 0);
            this.Controls.SetChildIndex(this.textBoxPublisherName, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.comboBoxCountry, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPublisherID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPublisherName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPublisherName;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelPublisherID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPublisherID;
        private System.Windows.Forms.TextBox textBoxPublisherName;
        private System.Windows.Forms.ErrorProvider errorProviderPublisherID;
        private System.Windows.Forms.ErrorProvider errorProviderPublisherName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxCountry;
    }
}
