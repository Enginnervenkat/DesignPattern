class RoadTransport : Transport{
    public override IProduct FactoryMethod(){
        return new RoadProduct();
    }
}