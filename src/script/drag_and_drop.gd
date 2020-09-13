extends KinematicBody2D

var clicked = false

signal dragSignal;

func _ready():
	connect("dragSignal",self,"_set_drag")
	
	
func _process(delta):
	if clicked:
		var mousepos = get_viewport().get_mouse_position()
		self.position = Vector2(mousepos.x-352, mousepos.y-226)
		

		

func _set_drag():
	clicked=!clicked


func _on_KinematicBody2D_input_event(viewport, event, shape_idx):
	if event is InputEventMouseButton:
		if event.button_index == BUTTON_LEFT and event.pressed:
			emit_signal("dragSignal")
		elif event.button_index == BUTTON_LEFT and !event.pressed:
			emit_signal("dragSignal")
	elif event is InputEventScreenTouch:
		if event.pressed and event.get_index() == 0:
			self.position = event.get_position()
