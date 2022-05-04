
namespace zh
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation15 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation16 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.title = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.views = new System.Windows.Forms.TextBox();
            this.likes = new System.Windows.Forms.TextBox();
            this.links = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            lineAnnotation15.LineColor = System.Drawing.Color.Aqua;
            lineAnnotation15.Name = "views";
            lineAnnotation16.LineColor = System.Drawing.Color.YellowGreen;
            lineAnnotation16.Name = "Like";
            this.chart1.Annotations.Add(lineAnnotation15);
            this.chart1.Annotations.Add(lineAnnotation16);
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(861, 77);
            this.chart1.Name = "chart1";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "views";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "likes";
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(617, 329);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(91, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 3;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(197, 41);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(100, 20);
            this.author.TabIndex = 4;
            this.author.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(303, 41);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 20);
            this.date.TabIndex = 5;
            this.date.TextChanged += new System.EventHandler(this.date_TextChanged);
            // 
            // views
            // 
            this.views.Location = new System.Drawing.Point(409, 41);
            this.views.Name = "views";
            this.views.Size = new System.Drawing.Size(100, 20);
            this.views.TabIndex = 6;
            this.views.TextChanged += new System.EventHandler(this.views_TextChanged);
            // 
            // likes
            // 
            this.likes.Location = new System.Drawing.Point(515, 41);
            this.likes.Name = "likes";
            this.likes.Size = new System.Drawing.Size(100, 20);
            this.likes.TabIndex = 7;
            this.likes.TextChanged += new System.EventHandler(this.likes_TextChanged);
            // 
            // links
            // 
            this.links.Location = new System.Drawing.Point(621, 41);
            this.links.Name = "links";
            this.links.Size = new System.Drawing.Size(100, 20);
            this.links.TabIndex = 8;
            this.links.TextChanged += new System.EventHandler(this.links_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1081, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Diagram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "egy author név kiválasztása után a diagram megjeleniti a nézettséget és a likeoka" +
    "t";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "A linkre kattintva az alapértelmezett böngészővel megnyitja az oldalt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 740);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.links);
            this.Controls.Add(this.likes);
            this.Controls.Add(this.views);
            this.Controls.Add(this.date);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox views;
        private System.Windows.Forms.TextBox likes;
        private System.Windows.Forms.TextBox links;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

