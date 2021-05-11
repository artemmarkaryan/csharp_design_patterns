class Program
{

  //Неправильно
  class BadAnimal
    {
      public BadAnimal(string name) { }
      public void getAnimalName() { }
      public void saveAnimal(BadAnimal a) { }
    }

    //Правильно
    class GoodAnimal
    {
      public GoodAnimal(string name) { }
      public void getAnimalName() { }
    }
    class GoodAnimalDB
    {
      public GoodAnimal getAnimal(int id) { }
      public void saveAnimal(GoodAnimal a) { }
    }

}
