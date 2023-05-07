using OpenWorld.Transport.Abstractions.Messages.Raw;

namespace OpenWorld.Transport.Abstractions.Initializers;

/// <summary>
/// Описывает инфраструктурного инициализатора.
/// </summary>
/// <typeparam name="TRawMessage">
/// Тип исходного сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IRawInitializer<TRawMessage, TValue>
    where TRawMessage : IRawMessage<TValue>
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
    public Task<IReadOnlyCollection<TRawMessage>> InitializeAsync(CancellationToken token);
}