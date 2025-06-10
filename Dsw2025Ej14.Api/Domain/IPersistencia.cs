namespace Dsw2025Ej14.Api.Domain;

public interface IPersistencia
{
    public IEnumerable<Product> GetProducts();
    public Product GetProduct(string sku);
    public void LoadProducts(); 
}
