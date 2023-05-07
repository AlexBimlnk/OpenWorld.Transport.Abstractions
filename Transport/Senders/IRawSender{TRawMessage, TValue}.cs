using OpenWorld.Transport.Abstractions.Messages.Raw;

namespace OpenWorld.Transport.Abstractions.Senders;

/// <summary>
/// Описывает инфраструктурного отправителя.
/// </summary>
/// <typeparam name="TRawMessage">
/// Тип исходного сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IRawSender<TRawMessage, TValue>
    where TRawMessage : IRawTargetMessage<TValue>
{
    /// <summary>
    /// Отправляет исходное сообщение.
    /// </summary>
    /// <param name="message">
    /// Сообщение.
    /// </param>
    /// <param name="token">
    /// Токен отмены операции.
    /// </param>
    /// <returns>
    /// <see cref="Task"/>, который завершится, когда сообщение будет отправлено.
    /// </returns>
    public Task SendAsync(TRawMessage message, CancellationToken token);
}