abstract class Transport{
    public abstract IProduct FactoryMethod();

    public string returnrelatedOperation(){
        var product = FactoryMethod();
        return product.returnState();
    }
}