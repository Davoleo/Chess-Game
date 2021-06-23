using ChessGame.script.Utils;
using Godot;

namespace ChessGame.script.Pieces
{
    public abstract class ChessPiece : Node2D
    {
        private Vector2 virtualPosition;
        private readonly EnumTeam team;

        //state
        private Vector2 targetPos;
        private bool selected;

        protected ChessPiece()
        {
            this.team = EnumTeam.WHITE;
        }

        public override void _Ready()
        {
            var chessboard = GetParent<Chessboard>();
            virtualPosition = chessboard.WorldToMap(Position);
            chessboard.AddPiece(this, virtualPosition);

            //Connect("input_event", GetParent(), "On_ChessPiece_Selected");
        }

        public abstract bool Move(Vector2 targetPos);

        // ReSharper disable once ParameterHidesMember
        public void SetSelected(bool selected)
        {
            if (this.selected == selected)
                return;

            this.selected = selected;
            this.Modulate = selected ? Colors.Coral : Colors.White;
        }
    }
}