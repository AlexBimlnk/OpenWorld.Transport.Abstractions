namespace OpenWorld.Transport.Abstractions.Messages;

/// <summary>
/// Описывает исходное сообщение с ключом, используемое инфраструктурным транспортом.
/// </summary>
/// <typeparam name="TKey">
/// Тип ключа сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IKeyableRawMessage<TKey, TValue> : IRawMessage<TValue>
{
    /// <summary>
    /// Ключ сообщения.
    /// </summary>
    public TKey Key { get; }
}