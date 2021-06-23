using System;
using System.Collections.Generic;
using ChessGame.script.Pieces;
using Godot;

namespace ChessGame.script
{
    public class Chessboard : TileMap
    {
	    public const int UNIT = 3 * 19;
	    private Vector2 mapSize;

	    private Dictionary<Vector2, ChessPiece> _pieces = new Dictionary<Vector2, ChessPiece>();

	    public override void _Ready()
	    {
		    CellSize = new Vector2(UNIT, UNIT);
		    mapSize = GetViewport().Size;
	    }

	    /// <summary>
	    /// Adds a new Piece and its cell position to the Map
	    /// </summary>
	    /// <param name="piece">The Piece to add to the Map</param>
	    /// <param name="pos">The virtual position in which the Piece is located</param>
	    /// <returns>the old piece if the edit overrode another piece position, null otherwise</returns>
	    public ChessPiece AddPiece(ChessPiece piece, Vector2 pos)
	    {
		    if (_pieces.ContainsKey(pos))
		    {
			    //Old Spice kek
			    var oldPiece = _pieces[pos];
			    _pieces[pos] = piece;
			    return oldPiece;
		    }
		    else
		    {
			    _pieces.Add(pos, piece);
			    return null;
		    }
	    }

	    /// <summary>
	    /// Removes a position/piece pair from the Map
	    /// </summary>
	    /// <returns>true if there was actually something to remove, false otherwise</returns>
	    public bool RemovePiece(Vector2 pos)
	    {
		    if (!_pieces.ContainsKey(pos))
			    return false;

		    _pieces.Remove(pos);
		    return true;
	    }

	    public override void _UnhandledInput(InputEvent @event)
	    {
		    if (@event is InputEventMouseButton mouseEvent)
		    {
			    //If the main thing used to select ui controls is used in the event we select the piece
			    if (mouseEvent.IsActionPressed("click"))
			    {
				    Vector2 eventCellPos = WorldToMap(mouseEvent.Position);
				    //Console.WriteLine(eventCellPos.ToString());
				    if (_pieces.ContainsKey(eventCellPos))
				    {
					    _pieces[eventCellPos].Modulate = Colors.Coral;
					    Console.WriteLine("PAWN, SALMON CORAL");
				    }

				    Console.WriteLine("Selected");
			    }
		    }
	    }
    }
}