namespace CollectionSorting;

public class ProdComparer:IComparer<Product>
{
    public int Compare(Product p2, Product p3)
    {
        // if(p2.price>p3.price)
        // {
        //     return 1;
        // }
        // else if(p2.price<p3.price)
        // {
        //     return -1;
        // }
        // else
        // {
        //     return 0;
        // }

        return p2.price.CompareTo(p3.price);
    }
}
