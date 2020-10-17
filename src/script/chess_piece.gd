extends KinematicBody2D

class_name Pawn

var virtual_position = position / (19 * 3)
var target = Vector2()

var selected = false
 
func _ready():
	self.connect("input_event", get_parent(), "_on_chess_piece_selected")
