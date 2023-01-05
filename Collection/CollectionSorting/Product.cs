namespace CollectionSorting;
using System.Collections;

public class Product:IComparable
{
    public int id {set;get;}
    public string name{set;get;}
    public double price{set;get;}

    public override string ToString(){
        return "ID = "+id+ "  Name = "+name+ "  Price = "+price;
    }

    public int CompareTo(Object obj)
    {
        Product anotherprod=(Product)obj;

        // if(this.id>anotherprod.id) return 1;
        // if(this.id<anotherprod.id) return -1;
        // else return 0;

        return this.name.CompareTo(anotherprod.name);
    }
}
