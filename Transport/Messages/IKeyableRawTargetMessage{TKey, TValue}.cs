namespace OpenWorld.Transport.Abstractions.Messages;

/// <summary>
/// Описывает исходное сообщение с ключом, обогащенное информацией о месте назначения.
/// </summary>
/// <typeparam name="TKey">
/// Тип ключа сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IKeyableRawTargetMessage<TKey, TValue> :
    IKeyableRawMessage<TKey, TValue>,
    IRawTargetMessage<TValue>
{
}