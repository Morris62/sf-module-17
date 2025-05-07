namespace Module_17;

public abstract class Account(double balance)
{
    protected double Balance { get; set; } = balance;

    protected double Interest { get; set; }

    public override string ToString()
    {
        return $"На счету: {Balance}, процентная ставка: {Interest}";
    }
}