class SeaTransport : Transport{
    public override IProduct FactoryMethod(){
        return new SeaProduct();
    }
}