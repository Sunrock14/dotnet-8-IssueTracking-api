using System.Linq.Expressions;

namespace IssueTracking.Core.BaseRepository;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    /// <summary>
    /// Yeni bir varlığı depoya ekler.
    /// </summary>
    /// <param name="entity">Eklenecek varlık.</param>
    /// <returns>Eklenen varlık.</returns>
    Task<T> AddAsync(T entity);

    /// <summary>
    /// Mevcut bir varlığı depoda günceller.
    /// </summary>
    /// <param name="entity">Güncellenecek varlık.</param>
    /// <returns>Güncellenen varlık.</returns>
    Task<T> UpdateAsync(T entity);

    /// <summary>
    /// Mevcut bir varlığı depodan siler.
    /// </summary>
    /// <param name="entity">Silinecek varlık.</param>
    Task DeleteAsync(T entity);

    /// <summary>
    /// Belirtilen kritere uyan bir varlığın mevcut olup olmadığını kontrol eder.
    /// </summary>
    /// <param name="predicate">Kontrol edilecek kriter.</param>
    /// <returns>Varlığın mevcut olup olmadığını belirten bir değer.</returns>
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

    /// <summary>
    /// Belirtilen kritere uyan varlıkların sayısını döndürür.
    /// </summary>
    /// <param name="predicate">Sayılacak kriter.</param>
    /// <returns>Varlıkların sayısı.</returns>
    Task<int> CountAsync(Expression<Func<T, bool>> predicate);

    /// <summary>
    /// Belirtilen kritere uyan bir varlığı getirir.
    /// </summary>
    /// <param name="predicate">Getirilecek kriter.</param>
    /// <param name="includeProperties">Dahil edilecek ilişkili varlıklar.</param>
    /// <returns>Getirilen varlık.</returns>
    Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

    /// <summary>
    /// Belirtilen kritere uyan tüm varlıkları getirir.
    /// </summary>
    /// <param name="predicate">Getirilecek kriter (varsayılan olarak null).</param>
    /// <param name="includeProperties">Dahil edilecek ilişkili varlıklar.</param>
    /// <returns>Getirilen varlıklar listesi.</returns>
    Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includeProperties);

    /// <summary>
    /// Belirtilen kriterler listesine uyan varlıkları arar.
    /// </summary>
    /// <param name="predicates">Aranacak kriterler listesi.</param>
    /// <param name="includeProperties">Dahil edilecek ilişkili varlıklar.</param>
    /// <returns>Arama sonuçları listesi.</returns>
    Task<IList<T>> SearchAsync(IList<Expression<Func<T, bool>>> predicates, params Expression<Func<T, object>>[] includeProperties);

    /// <summary>
    /// Varlıkları sorgulamak için kullanılabilir bir sorgu döner.
    /// </summary>
    /// <returns>Sorgulanabilir varlıklar.</returns>
    IQueryable<T> GetAsQueryable();
}
