namespace OpenWorld.Transport.Abstractions.Serialization;

/// <summary>
/// Описывает сериализатора сообщений из 
/// <typeparamref name="TSource"/> в <typeparamref name="TTarget"/>.
/// </summary>
/// <typeparam name="TSource">
/// Тип, подвергающийся сериализации.
/// </typeparam>
/// <typeparam name="TTarget">
/// Тип, являющийся результатом сериализации.
/// </typeparam>
public interface ISerializer<TSource, TTarget>
{
    /// <summary>
    /// Сериализует исходный объект.
    /// </summary>
    /// <param name="source">
    /// Исходный объект, подвергающийся сериализации.
    /// </param>
    /// <param name="token">
    /// Токен отмены операции.
    /// </param>
    /// <returns>
    /// <see cref="ValueTask{TResult}"/>, который завершится, когда сериализация будет проведена.
    /// </returns>
    public ValueTask<TTarget> SerializeAsync(TSource source, CancellationToken token);
}