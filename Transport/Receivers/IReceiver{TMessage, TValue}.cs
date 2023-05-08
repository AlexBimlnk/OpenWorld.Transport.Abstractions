using OpenWorld.Transport.Abstractions.Messages.Structured;

namespace OpenWorld.Transport.Abstractions.Receivers;

/// <summary>
/// Описывает конечного получателя.
/// </summary>
/// <typeparam name="TMessage">
/// Тип исходного сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IReceiver<TMessage, TValue>
    where TMessage : IReceivedMessage<TValue>
{
    /// <summary>
    /// Получает сообщение.
    /// </summary>
    /// <param name="token">
    /// Токен отмены операции.
    /// </param>
    /// <returns>
    /// <see cref="Task{TResult}"/>, который завершится, когда сообщение будет получено.
    /// </returns>
    public Task<TMessage> ReceiveAsync(CancellationToken token);
}