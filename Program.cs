using DrawShapes.Classes;

int shape;
var draw = new Draw();
do
{
    Report.ShowMenu();
    shape = ValueManipulator.ConvertOptionValue();

    switch (shape)
    {
        case 1: draw.DrawTriangle(); break;
        case 2: draw.DrawRectangle(); break;
        case 3: draw.DrawRhombus(); break;
        case 4: Report.ExitFromProgram(); break;
        default: Report.DefaultCase(); break;
    }

} while (shape != 4);