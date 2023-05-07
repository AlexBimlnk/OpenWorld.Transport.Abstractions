namespace OpenWorld.Transport.Abstractions.Serialization;

/// <summary>
/// Описывает десериализатора сообщений из 
/// <typeparamref name="TSource"/> в <typeparamref name="TTarget"/>.
/// </summary>
/// <typeparam name="TSource">
/// Тип, подвергающийся десериализации.
/// </typeparam>
/// <typeparam name="TTarget">
/// Тип, являющийся результатом десериализации.
/// </typeparam>
public interface IDeserializer<TSource, TTarget>
{
    /// <summary>
    /// Десериализует исходный объект.
    /// </summary>
    /// <param name="source">
    /// Исходный объект, подвергающийся десериализации.
    /// </param>
    /// <param name="token">
    /// Токен отмены операции.
    /// </param>
    /// <returns>
    /// <see cref="ValueTask{TResult}"/>, который завершится, когда десериализация будет проведена.
    /// </returns>
    public ValueTask<TTarget> DeserializeAsync(TSource source, CancellationToken token);
}