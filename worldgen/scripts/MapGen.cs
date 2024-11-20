using Godot;
using System;

public partial class MapGen : Node2D
{
	
	private TileMapLayer stone;
	private TileMapLayer dirt;
	
	public override void _Ready()
	{
		dirt = GetNode<TileMapLayer>("dirt");
		int x = 20;
		int y = 20;
		initMap(x, y);
		dirt.SetCell(new Vector2I(10,10),1, new Vector2I(1,2));
	}
	
	private void initMap(int X, int Y)
	{
		stone = GetNode<TileMapLayer>("stone");
		
		if (stone == null)
		{
			GD.Print("TileMapLayer 'stone' not found!");
			return;
		}
		
		for (int x = 0; x < X; x++)
		{
			for (int y = 0; y < Y; y++)
			{
				GD.Print($"Setting cell at ({x}, {y})");
				stone.SetCell(new Vector2I(x, y), 0,new Vector2I(3,1));
			}
		}
	}
	
	public override void _Process(double delta)
	{
	}
}
