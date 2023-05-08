namespace OpenWorld.Transport.Abstractions.Messages.Structured;

/// <summary>
/// Описывает полученное сообщение с ключом,
/// обогащенное информацией об источнике.
/// </summary>
/// <typeparam name="TKey">
/// Тип ключа сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IKeyableReceivedMessage<TKey, TValue> :
    IKeyableMessage<TKey, TValue>,
    IReceivedMessage<TValue>
    where TKey : IEquatable<TKey>
{
}