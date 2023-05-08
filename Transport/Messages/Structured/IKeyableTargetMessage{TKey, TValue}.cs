namespace OpenWorld.Transport.Abstractions.Messages.Structured;

/// <summary>
/// Описывает сообщение с ключом, обогащенное информацией о месте назначения.
/// </summary>
/// <typeparam name="TKey">
/// Тип ключа сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IKeyableTargetMessage<TKey, TValue> :
    IKeyableMessage<TKey, TValue>,
    ITargetMessage<TValue>
    where TKey : IEquatable<TKey>
{
}