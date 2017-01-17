namespace OOPTeamwork.Core.Contracts
{
    using System.Windows.Forms;

    public interface IGameBorder
    {
        string Caption { get; set; }

        Form Form { get; set; }
    }
}
