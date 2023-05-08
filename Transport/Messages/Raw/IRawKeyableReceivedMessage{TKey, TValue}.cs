namespace OpenWorld.Transport.Abstractions.Messages.Raw;

/// <summary>
/// Описывает полученное исходное сообщение с ключом,
/// обогащенное информацией об источнике.
/// </summary>
/// <typeparam name="TKey">
/// Тип ключа сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IRawKeyableReceivedMessage<TKey, TValue> :
    IRawKeyableMessage<TKey, TValue>,
    IRawReceivedMessage<TValue>
    where TKey : IEquatable<TKey>
{
}