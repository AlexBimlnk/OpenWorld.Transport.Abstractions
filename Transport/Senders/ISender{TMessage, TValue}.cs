using OpenWorld.Transport.Abstractions.Messages.Structured;

namespace OpenWorld.Transport.Abstractions.Senders;

/// <summary>
/// Описывает конечного отправителя.
/// </summary>
/// <typeparam name="TMessage">
/// Тип сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface ISender<TMessage, TValue>
    where TMessage : ITargetMessage<TValue>
{
    /// <summary>
    /// Отправляет сообщение.
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
    public Task SendAsync(TMessage message, CancellationToken token);
}