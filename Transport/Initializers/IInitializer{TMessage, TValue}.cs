using OpenWorld.Transport.Abstractions.Messages.Structured;

namespace OpenWorld.Transport.Abstractions.Initializers;

/// <summary>
/// Описывает конечного инициализатора.
/// </summary>
/// <typeparam name="TMessage">
/// Тип исходного сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IInitializer<TMessage, TValue>
    where TMessage : IReceivedMessage<TValue>
{
    /// <summary>
    /// Инициализирует коллекцию исходных сообщений.
    /// </summary>
    /// <param name="token">
    /// Токен отмены операции.
    /// </param>
    /// <returns>
    /// <see cref="Task{TResult}"/>, который завершится, когда сообщения инициализируются. 
    /// </returns>
    public Task<IReadOnlyCollection<TMessage>> InitializeAsync(CancellationToken token);
}