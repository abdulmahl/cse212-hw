public class TakingTurnsQueue
{
    private readonly Queue<Person> _people = new();

    public int Length => _people.Count;

    /// <summary>
    /// Add a new person to the queue with a name and number of turns.
    /// </summary>
    /// <param name="name">Name of the person</param>
    /// <param name="turns">Number of turns the person has (0 or less for infinite turns)</param>
    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    /// <summary>
    /// Get the next person in the queue. If the person has finite turns, they are placed back
    /// in the queue with their turn count decremented, unless their turns have run out. 
    /// If they have infinite turns (0 or fewer), they are placed back in the queue unchanged.
    /// </summary>
    /// <returns>The next person in the queue</returns>
    public Person GetNextPerson()
    {
        if (_people.Count == 0)
        {
            throw new InvalidOperationException("No one in the queue.");
        }

        var person = _people.Dequeue();

        // Handle finite turns
        if (person.Turns > 0)
        {
            person.Turns -= 1;
            if (person.Turns > 0)
            {
                // Person still has turns left, so re-enqueue them.
                _people.Enqueue(person);
            }
        }
        else
        {
            // Person has infinite turns (0 or less), re-enqueue without decrementing turns.
            _people.Enqueue(person);
        }

        return person;
    }

    public override string ToString()
    {
        return string.Join(", ", _people);
    }
}
