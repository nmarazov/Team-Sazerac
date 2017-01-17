namespace OOPTeamwork.Core.GameBoardFolder
{
    using System.Drawing;
    using System.Windows.Forms;
    using OOPTeamwork.Core.GameBoardFolder.Contracts;
    using OOPTeamwork.Common;

    public class PanelSazerac : Panel, IDentificable
    {
        private static int id = 0;

        public PanelSazerac(Point pos, Size size) : base()
        {
            base.Location = pos;
            base.Size = size;
            base.BackColor = Color.Transparent;
            base.MouseDown += new MouseEventHandler(panel_MouseDown);
            this.ID = id++;
        }

        public int ID { get; private set; }

        // when mouse down
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            var p = (PanelSazerac) sender;
            //Console.WriteLine("mouse cliced on panel ID:{0}", p.ID);
            if (e.Button == MouseButtons.Left)
            {
                p.BackgroundImage = Images.imageX;
            }
            if (e.Button == MouseButtons.Right)
            {
                p.BackgroundImage = Images.imageO;
            }

        }
    }
}