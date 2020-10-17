extends Area2D

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
const cell_size = 3 * 19

# Called when the node enters the scene tree for the first time.
func _ready():
	map_size = get_viewport().size
	pass

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(_delta):
	pass