namespace OpenWorld.Transport.Abstractions.Messages.Raw;

/// <summary>
/// Описывает исходное сообщение с ключом, обогащенное информацией о месте назначения.
/// </summary>
/// <typeparam name="TKey">
/// Тип ключа сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IRawKeyableTargetMessage<TKey, TValue> :
    IRawKeyableMessage<TKey, TValue>,
    IRawTargetMessage<TValue>
    where TKey : IEquatable<TKey>
{
}