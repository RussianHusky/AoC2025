using System.Security.AccessControl;

int dial = 50;
while (true)
{
    
}

int Rotate(int dial, string command)
{
    int rotation;
    switch (command[0])
    {
        case 'L':
            rotation = Convert.ToInt32(command.Remove(0, 1));
            if (dial - rotation < 0)
                return 99 - rotation;
            return 99 - rotation - dial;
        case 'R':
            rotation = Convert.ToInt32(command.Remove(0, 1));
            if (dial + rotation > 99)
                return 99 - rotation;
            return dial + rotation;
    }

    return dial;
}