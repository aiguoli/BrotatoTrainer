namespace BrotatoTrainer
{
    partial class MainWindow
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
            money = new Label();
            moneyInput = new TextBox();
            changeMoneyButton = new Button();
            bgWorker = new System.ComponentModel.BackgroundWorker();
            processStatus = new Label();
            SuspendLayout();
            // 
            // money
            // 
            money.AutoSize = true;
            money.Location = new Point(19, 44);
            money.Name = "money";
            money.Size = new Size(48, 17);
            money.TabIndex = 0;
            money.Text = "Money";
            // 
            // moneyInput
            // 
            moneyInput.Location = new Point(73, 41);
            moneyInput.Name = "moneyInput";
            moneyInput.Size = new Size(100, 23);
            moneyInput.TabIndex = 1;
            // 
            // changeMoneyButton
            // 
            changeMoneyButton.Location = new Point(179, 40);
            changeMoneyButton.Name = "changeMoneyButton";
            changeMoneyButton.Size = new Size(75, 24);
            changeMoneyButton.TabIndex = 2;
            changeMoneyButton.Text = "change";
            changeMoneyButton.UseVisualStyleBackColor = true;
            changeMoneyButton.Click += ChangeMoneyButton_Click;
            // 
            // bgWorker
            // 
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
            // 
            // processStatus
            // 
            processStatus.AutoSize = true;
            processStatus.Location = new Point(19, 9);
            processStatus.Name = "processStatus";
            processStatus.Size = new Size(26, 17);
            processStatus.TabIndex = 5;
            processStatus.Text = "Init";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 81);
            Controls.Add(processStatus);
            Controls.Add(changeMoneyButton);
            Controls.Add(moneyInput);
            Controls.Add(money);
            MinimumSize = new Size(290, 120);
            Name = "MainWindow";
            Text = "BrotatoTrainer";
            Load += Window_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label money;
        private TextBox moneyInput;
        private Button changeMoneyButton;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private Label processStatus;
    }
}
