public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        // Check if there is a valid entry for the current position
        if (_mazeMap.TryGetValue((_currX, _currY), out var directions))
        {
            // Check if moving left is allowed (index 0 in the directions array)
            if (directions[0])
            {
                _currX--; // Move left
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out var directions))
        {
            // Check if moving right is allowed (index 1 in the directions array)
            if (directions[1])
            {
                _currX++; // Move right
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out var directions))
        {
            // Check if moving up is allowed (index 2 in the directions array)
            if (directions[2])
            {
                _currY--; // Move up
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out var directions))
        {
            // Check if moving down is allowed (index 3 in the directions array)
            if (directions[3])
            {
                _currX = _currY++; // Move down
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}
