using ChessGame.script.Utils;
using Godot;

namespace ChessGame.script.Pieces
{
    public abstract class ChessPiece : Node2D
    {
        [Signal]
        public delegate void OnSelectionChanged(bool newValue);

        private Vector2 virtualPosition;
        private readonly EnumTeam team;

        //state
        private Vector2 targetPos;
        private bool selected;

        protected ChessPiece(EnumTeam team)
        {
            this.team = team;
        }

        public override void _Ready()
        {
            var chessboard = GetParent<Chessboard>();
            virtualPosition = chessboard.WorldToMap(Position);
            chessboard.AddPiece(this, virtualPosition);

            //Connect("input_event", GetParent(), "On_ChessPiece_Selected");
        }

        public abstract EnumMovementResult Move(Vector2 targetPos);

        public abstract PieceTypes GetPieceType();

        public bool Selected
        {
            get => selected;
            set
            {
                selected = value;
                Modulate = selected ? Colors.Coral : Colors.White;
                EmitSignal(nameof(OnSelectionChanged), value);
            }
        }
    }
}