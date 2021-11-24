using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "2D-topdown game"); //titelbar i programmet.
Raylib.SetTargetFPS(60);

//steg 1 - rectangel

//float x = 4.5f;

Raylib.DrawRectangleRec(playerRect, Color.BEIGE);

Rectangle playerRect = new Rectangle(10, 10, 32, 32);

//--
//steg 2 - textur (bilder)

Texture2D playerImage = Raylib.LoadTexture("bildnamn.png"); //bilden måste vara i png-format

while (Raylib.WindowShouldClose() == false) //kan stänga programmet med X knappen i hörnet.
{
    Raylib.BeginDrawing();
    Raylib.DrawRectangle(10, 10, 32, 32, Color.BLACK);
    //steg 2 - Raylib.DrawTexture(playerImage ,45, 70, Color.WHITE);
    Raylib.ClearBackground(Color.RED);
    Raylib.EndDrawing();
}