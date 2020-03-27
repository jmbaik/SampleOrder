namespace SampleOrder
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginButton = new System.Windows.Forms.Button();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.requestButton = new System.Windows.Forms.Button();
            this.balanceDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.예수금 = new System.Windows.Forms.Label();
            this.총매입금 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.총평가금 = new System.Windows.Forms.Label();
            this.총손익금 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(64, 26);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(187, 47);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "로그인";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(1833, 1241);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 1;
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(439, 26);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(309, 32);
            this.accountComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "계좌번호";
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(788, 28);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(136, 39);
            this.requestButton.TabIndex = 4;
            this.requestButton.Text = "조회";
            this.requestButton.UseVisualStyleBackColor = true;
            // 
            // balanceDataGridView
            // 
            this.balanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceDataGridView.Location = new System.Drawing.Point(69, 307);
            this.balanceDataGridView.Name = "balanceDataGridView";
            this.balanceDataGridView.RowTemplate.Height = 37;
            this.balanceDataGridView.Size = new System.Drawing.Size(1852, 717);
            this.balanceDataGridView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "보유주식잔고";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.예수금, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.총매입금, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.총평가금, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.총손익금, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(64, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1866, 100);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "예수금";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(1, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 49);
            this.label4.TabIndex = 1;
            this.label4.Text = "총매입금";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 예수금
            // 
            this.예수금.AutoSize = true;
            this.예수금.Dock = System.Windows.Forms.DockStyle.Fill;
            this.예수금.Location = new System.Drawing.Point(470, 1);
            this.예수금.Name = "예수금";
            this.예수금.Size = new System.Drawing.Size(459, 48);
            this.예수금.TabIndex = 2;
            this.예수금.Text = "0";
            this.예수금.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 총매입금
            // 
            this.총매입금.AutoSize = true;
            this.총매입금.Dock = System.Windows.Forms.DockStyle.Fill;
            this.총매입금.Location = new System.Drawing.Point(470, 50);
            this.총매입금.Name = "총매입금";
            this.총매입금.Size = new System.Drawing.Size(459, 49);
            this.총매입금.TabIndex = 3;
            this.총매입금.Text = "0";
            this.총매입금.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(936, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(459, 48);
            this.label7.TabIndex = 4;
            this.label7.Text = "총평가금";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(936, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(459, 49);
            this.label8.TabIndex = 5;
            this.label8.Text = "총손익금";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 총평가금
            // 
            this.총평가금.AutoSize = true;
            this.총평가금.Dock = System.Windows.Forms.DockStyle.Fill;
            this.총평가금.Location = new System.Drawing.Point(1402, 1);
            this.총평가금.Name = "총평가금";
            this.총평가금.Size = new System.Drawing.Size(460, 48);
            this.총평가금.TabIndex = 6;
            this.총평가금.Text = "0";
            this.총평가금.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 총손익금
            // 
            this.총손익금.AutoSize = true;
            this.총손익금.Dock = System.Windows.Forms.DockStyle.Fill;
            this.총손익금.Location = new System.Drawing.Point(1402, 50);
            this.총손익금.Name = "총손익금";
            this.총손익금.Size = new System.Drawing.Size(460, 49);
            this.총손익금.TabIndex = 7;
            this.총손익금.Text = "0";
            this.총손익금.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2034, 1313);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.balanceDataGridView);
            this.Controls.Add(this.requestButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.DataGridView balanceDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label 예수금;
        private System.Windows.Forms.Label 총매입금;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label 총평가금;
        private System.Windows.Forms.Label 총손익금;
    }
}

