namespace OpenWorld.Transport.Abstractions.Messages.Structured;

/// <summary>
/// Описывает подтверждаемое сообщение.
/// </summary>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface ICommitableMessage<TValue> : IReceivedMessage<TValue>
{
    /// <summary>
    /// Подтвержает получение сообщения.
    /// </summary>
    /// <returns>
    /// <see cref="Task"/>, который завершится, когда 
    /// получение сообщения будет подтверждено.
    /// </returns>
    public Task CommitAsync();
}
