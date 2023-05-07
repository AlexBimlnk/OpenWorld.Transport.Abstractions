using OpenWorld.Transport.Abstractions.Messages;

namespace OpenWorld.Transport.Abstractions.Receivers;

/// <summary>
/// Описывает инфраструктурного получателя.
/// </summary>
/// <typeparam name="TRawMessage">
/// Тип исходного сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IRawReceiver<TRawMessage, TValue>
    where TRawMessage : IRawMessage<TValue>
{
    /// <summary>
    /// Получает исходное сообщение.
    /// </summary>
    /// <param name="token">
    /// Токен отмены операции.
    /// </param>
    /// <returns>
    /// <see cref="Task"/>, который завершится, когда сообщение будет получено.
    /// </returns>
    public Task<TRawMessage> ReceiveAsync(CancellationToken token);
}