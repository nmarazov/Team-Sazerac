namespace OOPTeamwork.Core.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using OOPTeamwork.Common;
    using OOPTeamwork.Core.Contracts;
    using OOPTeamwork.Core.GameBoardFolder;

    public class GameBoardProvider : IGameBorder
    {
        private readonly Point[] posOfPanels = new Point[]
        {
            new Point(50, 50), new Point(120, 50), new Point(190, 50),
            new Point(50, 128), new Point(120, 128), new Point(190, 128),
            new Point(50, 206), new Point(120, 206), new Point(190, 206),
        };

        private Label label;

        public GameBoardProvider()
        {
            // set default panels
            this.Panels = new List<PanelSazerac>();
            foreach (var pos in posOfPanels)
            {
                this.Panels.Add(new PanelSazerac(pos, Images.imageX.Size));
            }

            // set Defaults for form
            this.Form = new Form();
            Form.Text = "Caption";
            Form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Form.BackColor = Color.Aquamarine;
            Form.Size = new Size(Images.imageBack.Size.Width + 24, Images.imageBack.Size.Height + 48);
            Form.Opacity = .85;
            Form.BackgroundImage = Images.imageBack;
            Form.StartPosition = FormStartPosition.CenterScreen;
            Form.Controls.AddRange(this.Panels.ToArray());

            // set up text
            this.label = new Label();
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 22);
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.BackColor = Color.Transparent;
            this.label.ForeColor = Color.Blue;
            this.label.Font = new Font(FontFamily.GenericSansSerif, 10);
            Form.Controls.Add(label);
        }

        public Form Form { get; set; }

        public IList<PanelSazerac> Panels { get; set; }

        public string SetTextOnBoard
        {
            get { return this.label.Text; }
            set { this.label.Text = value; }
        }

        public string Caption
        {
            get
            {
               return this.Form.Text;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(Constants.NullCaption);
                };
                this.Form.Text = value;
            }
        }
    }
}