extends TileMap

enum EnumPieces {
	PAWN,
	ROOK,
	KNIGHT,
	BISHOP,
	QUEEN,
	KING
}

var map_size
# scale * actual cell size in pixels
const unit = 3 * 19

# Called when the node enters the scene tree for the first time.
func _ready():
	map_size = get_viewport().size
	pass

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(_delta):
	pass

func _on_chess_piece_selected(_viewport, event, _shapeId):
	if event.is_action_pressed('click'):
		print("Selected")
