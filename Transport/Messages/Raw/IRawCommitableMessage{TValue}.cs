namespace OpenWorld.Transport.Abstractions.Messages.Raw;

/// <summary>
/// Описывает подтверждаемое исходное сообщение.
/// </summary>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IRawCommitableMessage<TValue> : IRawReceivedMessage<TValue>
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
